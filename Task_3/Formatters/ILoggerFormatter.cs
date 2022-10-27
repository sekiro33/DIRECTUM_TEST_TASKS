namespace Logger.Formatters
{
    public interface ILoggerFormatter
    {
        string ApplyFormat(LogMessage message);
    }
}
