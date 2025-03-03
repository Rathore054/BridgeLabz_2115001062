using BusinessLayer.Service;
using RepositoryLayer.Service;
using RepositoryLayer.Interface;
using BusinessLayer.Interface;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using NLog;
using NLog.Extensions.Logging;

var logger = LogManager.Setup().LoadConfiguration(config =>
{
    config.ForLogger()
          .FilterMinLevel(NLog.LogLevel.Info) 
          .WriteToFile("logs/app_log.txt")
          .WriteToConsole();
}).GetCurrentClassLogger();

try
{
    logger.Info("Application is starting...");

    var builder = WebApplication.CreateBuilder(args);

    // Configure Logging
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); // FIX
    builder.Logging.AddNLog();

    var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
    builder.Services.AddDbContext<HelloAppContext>(options => options.UseSqlServer(connectionString));

    // Add services to the container
    builder.Services.AddControllers();
    builder.Services.AddScoped<IRegisterHelloBL, RegisterHelloBL>();
    builder.Services.AddScoped<IRegisterHelloRL, RegisterHelloRL>();

    // Add Swagger
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Middleware configurations
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application failed to start due to an error.");
    throw;
}
finally
{
    LogManager.Shutdown();
}
