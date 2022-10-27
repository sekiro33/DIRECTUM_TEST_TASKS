using Logger.Handlers;
using System.Diagnostics;
using System.Reflection;

namespace Logger
{
    public class Logger : ILogger
    {
        private readonly LogPublisher _publisher;

        public Logger()
        {
            _publisher = new LogPublisher();
            DefaultInitialization();
        }

        public void DefaultInitialization()
        {
            _publisher.AddHandler(new ConsoleLoggerHandler());
        }

        public void LogException(string source, Exception exception, bool isCritical)
        {
            var stackFrame = GetStackFrame();
            var methodBase = GetCallingMethodBase(stackFrame);
            var callingMethod = methodBase.Name;
            var currentDateTime = DateTime.Now;
            var lineNumber = stackFrame.GetFileLineNumber();
            var logMessage = new LogMessage(LogMessageSeverity.ERROR, exception.Message, currentDateTime, source, callingMethod, lineNumber);
            _publisher.Publish(logMessage);
        }

        public void LogMessage(string source, string text, LogMessageSeverity severity)
        {
            var stackFrame = GetStackFrame();
            var methodBase = GetCallingMethodBase(stackFrame);
            var callingMethod = methodBase.Name;
            var currentDateTime = DateTime.Now;
            var lineNumber = stackFrame.GetFileLineNumber();
            var logMessage = new LogMessage(severity, text, currentDateTime, source, callingMethod, lineNumber);
            _publisher.Publish(logMessage);
        }

        public void Warning(string source, string text)
        {
            LogMessage(source, text, LogMessageSeverity.WARNING);
        }

        public void Error(string source, string text)
        {
            LogMessage(source, text, LogMessageSeverity.ERROR);
        }

        public void Debug(string source, string text)
        {
            LogMessage(source, text, LogMessageSeverity.DEBUG);
        }

        public void Info(string source, string text)
        {
            LogMessage(source, text, LogMessageSeverity.INFO);
        }

        private MethodBase GetCallingMethodBase(StackFrame stackFrame)
        {
            return stackFrame == null ? MethodBase.GetCurrentMethod() : stackFrame.GetMethod();
        }

        private StackFrame GetStackFrame()
        {
            var stackTrace = new StackTrace();
            for (var i = 0; i < stackTrace.GetFrames().Count(); i++)
            {
                var methodBase = stackTrace.GetFrame(i).GetMethod();
                var name = MethodBase.GetCurrentMethod().Name;
                if (!methodBase.Name.Equals("Log") && !methodBase.Name.Equals(name))
                    return new StackFrame(i, true);
            }
            return null;
        }
    }
}
