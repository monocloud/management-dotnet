namespace MonoCloud.Management.Models;

/// <summary>
/// User Session Metadata: Returns contextual and device information associated with a user session.
/// </summary>
public class UserSessionMetadata
{
  /// <summary>
  /// The city recorded during the most recent session activity.
  /// </summary>
  public string? City { get; set; }

  /// <summary>
  /// The country recorded during the most recent session activity.
  /// </summary>
  public string? Country { get; set; }

  /// <summary>
  /// The geographic region recorded during the most recent session activity.
  /// </summary>
  public string? Region { get; set; }

  /// <summary>
  /// The latitude recorded during the most recent session activity.
  /// </summary>
  public string? Latitude { get; set; }

  /// <summary>
  /// The longitude recorded during the most recent session activity.
  /// </summary>
  public string? Longitude { get; set; }

  /// <summary>
  /// The IP address recorded during the most recent session activity.
  /// </summary>
  public string? IpAddress { get; set; }

  /// <summary>
  /// The user agent recorded during the most recent session activity.
  /// </summary>
  public string? UserAgent { get; set; }
}


