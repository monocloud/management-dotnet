namespace MonoCloud.Management;

public static class MonoCloudManagementServiceExtensions
{
  public static IServiceCollection AddMonoCloudManagementClient(this IServiceCollection services, IConfiguration configuration) =>
    services.AddMonoCloudManagementClient(configuration, null);

  public static IServiceCollection AddMonoCloudManagementClient(this IServiceCollection services, Action<MonoCloudManagementOptions> options) =>
    services.AddMonoCloudManagementClient(null, options);

  public static IServiceCollection AddMonoCloudManagementClient(this IServiceCollection services, IConfiguration? configuration, Action<MonoCloudManagementOptions>? options)
  {
    string? domain = null;
    string? apiKey = null;
    int? timeout = null;

    if (configuration is not null)
    {
      var monocloudSection = configuration.GetSection("MonoCloud").GetSection("Management");
      domain = monocloudSection["Domain"];
      apiKey = monocloudSection["ApiKey"];

      if (int.TryParse(monocloudSection["Timeout"], out var result))
      {
        timeout = result;
      }
    }

    if (options is not null)
    {
      var settings = new MonoCloudManagementOptions();
      options.Invoke(settings);

      if (settings.Domain is not null)
      {
        domain = settings.Domain;
      }

      if (settings.ApiKey is not null)
      {
        apiKey = settings.ApiKey;
      }

      if (settings.Timeout.HasValue)
      {
        timeout = settings.Timeout.Value.Seconds;
      }
    }

    if (domain is null || string.IsNullOrEmpty(domain))
    {
      throw new ArgumentNullException(nameof(MonoCloudManagementOptions.Domain), "The domain for the MonoCloud Management client has not been set.");
    }

    if (apiKey is null || string.IsNullOrEmpty(apiKey))
    {
      throw new ArgumentNullException(nameof(MonoCloudManagementOptions.ApiKey), "The api key for the MonoCloud Management client has not been set.");
    }

    var config = new MonoCloudConfig(domain, apiKey, timeout.HasValue ? TimeSpan.FromSeconds(timeout.Value) : null);

    var clientName = "MonoCloudManagementClient";

    services.AddHttpClient(clientName)
      .ConfigureHttpClient(client =>
      {
        client.BaseAddress = new Uri($"{config.Domain}/api/");
        client.Timeout = config.Timeout;
        client.DefaultRequestHeaders.Add("X-API-KEY", config.ApiKey);
      });

    services.AddTransient(s =>
    {
      var factory = s.GetRequiredService<IHttpClientFactory>();
      var client = factory.CreateClient(clientName);
      return new MonoCloudManagementClient(client);
    });

    return services;
  }
}
