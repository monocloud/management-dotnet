namespace MonoCloud.Management.Models;

/// <summary>
/// Log System Response: Represents the system or application instance that generated the log entry.
/// </summary>
public class LogSystem
{
  /// <summary>
  /// The activity identifier associated with the request.
  /// </summary>
  public string? ActivityId { get; set; }

  /// <summary>
  /// The process identifier of the executing service.
  /// </summary>
  public int ProcessId { get; set; }

  /// <summary>
  /// The local IP address details of the service handling the request.
  /// </summary>
  public LogIpDetails LocalIp { get; set; }
}


