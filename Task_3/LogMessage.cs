using Logger.Formatters;

namespace Logger
{
    public class LogMessage
    {
        public DateTime DateTime { get; set; }
        public LogMessageSeverity Severity { get; set; }
        public string Text { get; set; }
        public string CallingClass { get; set; }
        public string CallingMethod { get; set; }
        public int LineNumber { get; set; }

        public LogMessage(LogMessageSeverity severity, string text, DateTime dateTime, string callingClass, string callingMethod, int lineNumber)
        {
            Severity = severity;
            Text = text;
            DateTime = dateTime;
            CallingClass = callingClass;
            CallingMethod = callingMethod;
            LineNumber = lineNumber;
        }

        public override string ToString()
        {
            return new DefaultLoggerFormatter().ApplyFormat(this);
        }
    }
}
