using k8s.Models;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace k8s.Tests
{
    class LineStreamReader : IAsyncLineReader
    {
        private readonly StreamReader _stream;

        public LineStreamReader(Stream stream)
        {
            _stream = new StreamReader(stream);
        }

        public async Task<string> ReadLineAsync(CancellationToken cancellationToken)
        {
            return await _stream.ReadLineAsync();
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }

    public class WatcherTests
    {
        [Fact]
        public void ReadError()
        {
            byte[] data = Encoding.UTF8.GetBytes("{\"type\":\"ERROR\",\"object\":{\"kind\":\"Status\",\"apiVersion\":\"v1\",\"metadata\":{},\"status\":\"Failure\",\"message\":\"too old resource version: 44982(53593)\",\"reason\":\"Gone\",\"code\":410}}");

            using (MemoryStream stream = new MemoryStream(data))
            using (LineStreamReader reader = new LineStreamReader(stream))
            {
                Exception recordedException = null;
                ManualResetEvent mre = new ManualResetEvent(false);

                Watcher<V1Pod> watcher = new Watcher<V1Pod>(
                    reader,
                    null,
                    (exception) =>
                    {
                        recordedException = exception;
                        mre.Set();
                    });

                mre.WaitOne();

                Assert.NotNull(recordedException);

                var k8sException = recordedException as KubernetesException;

                Assert.NotNull(k8sException);
                Assert.NotNull(k8sException.Status);
                Assert.Equal("too old resource version: 44982(53593)", k8sException.Message);
                Assert.Equal("too old resource version: 44982(53593)", k8sException.Status.Message);
            }
        }
    }
}
