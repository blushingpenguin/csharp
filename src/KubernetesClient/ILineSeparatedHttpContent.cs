namespace k8s
{
    public interface ILineSeparatedHttpContent
    {
        IAsyncLineReader StreamReader { get; }
    }
}
