using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace k8s.Tests
{
    internal class WatchTestsLineStreamReader : IAsyncLineReader
    {
        private readonly StreamReader _stream;

        public WatchTestsLineStreamReader(Stream stream)
        {
            _stream = new StreamReader(stream);
        }

        public async Task<string> ReadLineAsync(CancellationToken cancellationToken)
        {
            return await _stream.ReadLineAsync().ConfigureAwait(false);
        }

        public void Dispose()
        {
            _stream.Dispose();
        }
    }
}
