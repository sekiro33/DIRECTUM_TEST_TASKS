namespace Logger
{
    public interface ILogger
    {
        void LogMessage(string source, string text, LogMessageSeverity severity);
        void LogException(string source, Exception exception, bool isCritical);
    }
}
