using eCommerceApp.Application.Services.Interfaces.Logging;
using Microsoft.Extensions.Logging;
using Serilog.Core;

namespace eCommerceApp.Infrastructure.Services;

public class SerilogLoggerAdapter<T>(ILogger<T> logger) : IAppLogger<T>
{
    public void LogInformation(string message) => logger.LogInformation(message);

    public void LogWarning(string message) => logger.LogWarning(message);

    public void LogError(Exception ex, string message) => logger.LogError(ex, message);
}