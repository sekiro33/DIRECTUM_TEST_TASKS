namespace Logger
{
    public class LogPublisher : ILoggerHandlerManager
    {
        private readonly IList<ILoggerHandler> _loggerHandlers;

        public LogPublisher()
        {
            _loggerHandlers = new List<ILoggerHandler>();
        }

        public void Publish(LogMessage message)
        {
            foreach (var handler in _loggerHandlers)
            {
                handler.Publish(message);
            }
        }

        public ILoggerHandlerManager AddHandler(ILoggerHandler loggerHandler)
        {
            if (loggerHandler != null)
                _loggerHandlers.Add(loggerHandler);
            return this;
        }

        public bool RemoveHandler(ILoggerHandler loggerHandler)
        {
            return _loggerHandlers.Remove(loggerHandler);
        }
    }
}
