namespace MonoCloud.Management;

public class MonoCloudManagementOptions
{
  public string? Domain { get; set; }
  public string? ApiKey { get; set; }
  public TimeSpan? Timeout { get; set; }
}
