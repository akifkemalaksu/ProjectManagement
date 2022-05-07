using NLog;
using System;
using ProjectManagement.Contracts.Utilities.Logger;

namespace ProjectManagement.Logger.NLog
{
    public class LoggerService : ILoggerService
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message) => _logger.Debug(message);

        public void LogError(string message) => _logger.Error(message);

        public void LogInfo(string message) => _logger.Info(message);

        public void LogWarn(string message) => _logger.Warn(message);
    }
}