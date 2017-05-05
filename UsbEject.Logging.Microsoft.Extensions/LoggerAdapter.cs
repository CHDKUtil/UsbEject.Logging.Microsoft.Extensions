using Microsoft.Extensions.Logging;

namespace UsbEject.Logging.Microsoft.Extensions
{
    /// <summary>
    /// UsbEject Microsoft.Extensions.Logging Adapter
    /// </summary>
    public class LoggerAdapter : ILogger
    {
        private global::Microsoft.Extensions.Logging.ILogger Logger { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggerAdapter"/> class.
        /// </summary>
        /// <param name="loggerFactory">Logger factory.</param>
        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger("UsbEject");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            //Do nothing
        }

        /// <inheritdoc/>
        public void Log(LogLevel level, object obj)
        {
            Logger.Log(GetLogLevel(level), default(EventId), obj, null, null);
        }

        /// <inheritdoc/>
        public void Log(LogLevel level, string str)
        {
            Logger.Log(GetLogLevel(level), default(EventId), str, null, null);
        }

        /// <inheritdoc/>
        public void Log(LogLevel level, string format, object arg0)
        {
            string str = string.Format(format, arg0);
            Logger.Log(GetLogLevel(level), default(EventId), str, null, null);
        }

        /// <inheritdoc/>
        public void Log(LogLevel level, string format, params object[] args)
        {
            string str = string.Format(format, args);
            Logger.Log(GetLogLevel(level), default(EventId), str, null, null);
        }

        private static global::Microsoft.Extensions.Logging.LogLevel GetLogLevel(LogLevel level)
        {
            return (global::Microsoft.Extensions.Logging.LogLevel)level;
        }
    }
}
