

using Microsoft.Extensions.Logging;

namespace Web.Api.Infrastructure.Logging
{
    public class Logger : Web.Core.Frame.Interfaces.Services.ILogger
    {
        
        private static readonly ILogger logger;

        public void LogDebug(string message)
        {
            logger.LogDebug(message);
        }

        public void LogError(string message)
        {
            logger.LogError(message);
        }

        public void LogInfo(string message)
        {
            logger.LogInformation(message);
        }

        public void LogWarn(string message)
        {
            logger.LogWarning(message);
        }
    }
}
