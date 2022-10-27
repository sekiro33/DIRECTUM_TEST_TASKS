namespace Logger
{
    public interface ILoggerHandler
    {
        void Publish(LogMessage message);
    }
}
