namespace MonoCloud.Management.Models;

/// <summary>
/// Log Request Response: Represents request-level metadata associated with the log entry.
/// </summary>
public class LogRequest
{
  /// <summary>
  /// The trace identifier of the request.
  /// </summary>
  public string? TraceId { get; set; }

  /// <summary>
  /// The user agent associated with the request.
  /// </summary>
  public string? UserAgent { get; set; }

  /// <summary>
  /// The remote IP address of the request.
  /// </summary>
  public LogIpDetails? RemoteIp { get; set; }

  /// <summary>
  /// The geographical location from which the request was made.
  /// </summary>
  public LogLocation? Location { get; set; }
}


