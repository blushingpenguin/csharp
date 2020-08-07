using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace k8s
{
    public interface ILineSeparatedHttpContent
    {
        IAsyncLineReader StreamReader { get; }
    }

    /// <summary>
    /// This HttpDelegatingHandler is to rewrite the response and return first line to autorest client
    /// then use WatchExt to create a watch object which interact with the replaced http response to get watch works.
    /// </summary>
    internal class WatcherDelegatingHandler : DelegatingHandler
    {
        public HttpClient HttpClient { get; set; }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var originResponse = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (originResponse.IsSuccessStatusCode && request.Method == HttpMethod.Get) // all watches are GETs, so we can ignore others
            {
                string query = request.RequestUri.Query;
                int index = query.IndexOf("watch=true");
                if (index > 0 && (query[index - 1] == '&' || query[index - 1] == '?'))
                {
                    originResponse.Content = new LineSeparatedHttpContent(originResponse.Content, HttpClient?.Timeout, cancellationToken);
                }
            }

            return originResponse;
        }

        internal class LineSeparatedHttpContent : HttpContent, ILineSeparatedHttpContent
        {
            private readonly HttpContent _originContent;
            // This is to workaround https://github.com/dotnet/corefx/issues/9071
            private readonly CancellationToken _cancellationToken;
            private Stream _originStream;
            private TimeSpan? _timeout;

            public LineSeparatedHttpContent(HttpContent originContent, TimeSpan? timeout, CancellationToken cancellationToken)
            {
                _originContent = originContent;
                _timeout = timeout;
                _cancellationToken = cancellationToken;
            }

            public IAsyncLineReader StreamReader { get; private set; }

            protected override async Task SerializeToStreamAsync(Stream stream, TransportContext context)
            {
                _originStream = await _originContent.ReadAsStreamAsync().ConfigureAwait(false);

                var streamReader = new PeekableStreamReader(_originStream, timeout: _timeout);
                StreamReader = streamReader;

                var firstLine = await streamReader.PeekLineAsync(_cancellationToken).ConfigureAwait(false);
                if (!string.IsNullOrEmpty(firstLine))
                {
                    var lineBytes = Encoding.UTF8.GetBytes(firstLine);
                    await stream.WriteAsync(lineBytes, 0, lineBytes.Length, _cancellationToken).ConfigureAwait(false);
                    await stream.FlushAsync(_cancellationToken).ConfigureAwait(false);
                }
            }

            protected override bool TryComputeLength(out long length)
            {
                length = 0;
                return false;
            }
        }
    }
}
