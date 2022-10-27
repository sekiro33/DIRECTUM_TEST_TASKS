namespace Logger
{
    public interface ILoggerHandlerManager
    {
        ILoggerHandlerManager AddHandler(ILoggerHandler loggerHandler);

        bool RemoveHandler(ILoggerHandler loggerHandler);
    }
}
