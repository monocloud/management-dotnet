namespace MonoCloud.Management.Models;

/// <summary>
/// Log IP Details Response: Represents the IP address details associated with the log entry.
/// </summary>
public class LogIpDetails
{
  /// <summary>
  /// The IP address.
  /// </summary>
  public string Ip { get; set; }

  /// <summary>
  /// The IP address version.
  /// </summary>
  public string Version { get; set; }
}


