namespace MonoCloud.Management.Models;

/// <summary>
/// Log Client Response: Representing the client application associated with the log event.
/// </summary>
public class LogClient
{
  /// <summary>
  /// The unique identifier of the client application associated with the event.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  /// The display name of the client application.
  /// </summary>
  public string? Name { get; set; }
}


