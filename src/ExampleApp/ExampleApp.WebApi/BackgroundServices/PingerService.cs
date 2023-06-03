using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ExampleApp.WebApi.BackgroundServices
{
    public static class PingerServiceServiceCollectionExtensions
    {
        public static IServiceCollection AddPingerService(this IServiceCollection services)
        {
            services.TryAddSingleton(new PingSettings()
            {
                Timeout = TimeSpan.FromSeconds(5),
                Frequency = TimeSpan.FromSeconds(5),
                Target = "www.google.com"
            });

            services.AddHostedService<PingerService>();
            return services;
        }
    }
    public class PingSettings
    {
        public TimeSpan Timeout { get; set; }
        public TimeSpan Frequency { get; set; }
        public string? Target { get; set; }
    }
    public class PingerService : BackgroundService
    {
        // https://makolyte.com/aspdotnet-how-to-use-a-backgroundservice-for-long-running-and-periodic-tasks/

        private readonly Ping _ping = new();
        private readonly ILogger _logger;
        private readonly PingSettings _settings;
        public PingerService(
            ILogger<PingerService> logger,
            PingSettings pingSettings
            )
        {
            _settings = pingSettings;
            _logger = logger;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(_settings.Frequency, stoppingToken);

                if (!string.IsNullOrEmpty(_settings.Target))
                {
                    try
                    {
                        var pingTask = _ping.SendPingAsync(_settings.Target, (int)_settings.Timeout.TotalMilliseconds);
                        var cancelTask = Task.Delay(_settings.Timeout, stoppingToken);

                        //double await so exceptions from either task will bubble up
                        await await Task.WhenAny(pingTask, cancelTask);

                        if (pingTask.IsCompletedSuccessfully)
                        {
                            var pingReply = pingTask.Result;
                            _logger.LogInformation(
                                $"PingReply status={{{nameof(pingReply.Status)}}} roundTripTime={{{nameof(pingReply.RoundtripTime)}}}",
                                pingReply.Status,
                                pingReply.RoundtripTime
                                );
                        }
                        else
                        {
                            _logger.LogError("Ping didn't complete successfully");
                        }

                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex.Message);
                    }
                }else
                {
                    _logger.LogError("Ping not configured");
                }
            }
        }

        public override void Dispose()
        {
            if (_ping != null)
            {
                _ping.Dispose();
            }
            base.Dispose();
        }
    }
}
