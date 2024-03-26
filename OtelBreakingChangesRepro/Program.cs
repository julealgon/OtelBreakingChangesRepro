using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddOpenTelemetry()
    .WithMetrics(c => c.AddOtlpExporter())
    .WithTracing(c => c.AddOtlpExporter());

var host = builder.Build();
host.Run();
