using k8s.Models;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace k8s.Tests
{
    public class PeekableLineStreamReaderTests
    {
        private PeekableStreamReader CreateStream(string input, int maxLineLength = int.MaxValue)
        {
            var memoryStream = new MemoryStream();
            var bytes = Encoding.UTF8.GetBytes(input);
            memoryStream.Write(bytes, 0, bytes.Length);
            memoryStream.Position = 0;
            return new PeekableStreamReader(memoryStream, maxLineLength);
        }

        [Fact]
        public void CreateNullStreamThrows()
        {
            Assert.Throws<ArgumentNullException>(() =>
                new PeekableStreamReader(null));
        }

        [Fact]
        public void CreateNegativeMaxLineLengthThrows()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                using (var ms = new MemoryStream())
                {
                    new PeekableStreamReader(ms, -1);
                }
            });
        }

        [Fact]
        public void PeekDisposedThrows()
        {
            using (var peekableStream = CreateStream("one\ntwo\nthree"))
            {
                peekableStream.Dispose();
                Assert.ThrowsAsync<ObjectDisposedException>(
                    async () => await peekableStream.PeekLineAsync(CancellationToken.None).ConfigureAwait(false));
            }
        }

        [Fact]
        public void ReadDisposedThrows()
        {
            using (var peekableStream = CreateStream("one\ntwo\nthree"))
            {
                peekableStream.Dispose();
                peekableStream.Dispose();
                Assert.ThrowsAsync<ObjectDisposedException>(
                    async () => await peekableStream.ReadLineAsync(CancellationToken.None).ConfigureAwait(false));
            }
        }

        [Fact]
        public async Task PeekAllThenRead()
        {
            var ct = CancellationToken.None;
            using (var peekableStream = CreateStream("one\ntwo\nthree\n"))
            {
                Assert.Equal("one\n", await peekableStream.PeekLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("two\n", await peekableStream.PeekLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("three\n", await peekableStream.PeekLineAsync(ct).ConfigureAwait(false));
                Assert.Null(await peekableStream.PeekLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("one\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("two\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("three\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Null(await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
            }
        }

        [Fact]
        public async Task ReadWithBigLines()
        {
            var sb = new StringBuilder();
            sb.Append("one\n");
            sb.Append("two\n");
            sb.Append('9', 4500).Append('\n');
            sb.Append("three\n");
            sb.Append('6', 17432).Append('\n');
            var ct = CancellationToken.None;
            using (var peekableStream = CreateStream(sb.ToString()))
            {
                Assert.Equal("one\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("two\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal(new string('9', 4500) + "\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("three\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal(new string('6', 17432) + "\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
            }
        }

        [Fact]
        public async Task ReadLastLineWithNoNL()
        {
            var ct = CancellationToken.None;
            using (var peekableStream = CreateStream("one\ntwo\nthree"))
            {
                Assert.Equal("one\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("two\n", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Equal("three", await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Null(await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
                Assert.Null(await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
            }
        }

        [Fact]
        public async Task ReadLineOfMaximumLengthSucceeds()
        {
            var ct = CancellationToken.None;
            var s = new string('X', 32767) + "\n";
            using (var peekableStream = CreateStream(s, 32768))
            {
                Assert.Equal(s, await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
            }
        }

        [Fact]
        public void ReadLineBiggerThanMaxThrows()
        {
            var ct = CancellationToken.None;
            using (var peekableStream = CreateStream(new string('6', 32769), 32768))
            {
                Assert.ThrowsAsync<InvalidOperationException>(
                    async () => await peekableStream.ReadLineAsync(ct).ConfigureAwait(false));
            }
        }
    }
}
