namespace AnimalExhibition.Api.Configuration;

using Serilog;

/// <summary>
/// Logger Configuration
/// </summary>
public static class LoggerConfiguration
{
    /// <summary>
    /// Add logger
    /// </summary>
    public static void AddAppLogger(this WebApplicationBuilder builder)
    {
        var logger = new Serilog.LoggerConfiguration()//создание конфигурации
            .Enrich.WithCorrelationIdHeader()//добавление к логам уникального идентификатора в рамках одного реквеста
            .Enrich.FromLogContext()//подключение контекста, чтобы смотреть логи из request/response
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger(); //создание логгера 

        builder.Host.UseSerilog(logger, true);//подключение логгера
    }
}