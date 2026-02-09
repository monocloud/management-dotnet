namespace MonoCloud.Management.Models;

/// <summary>
/// Log Location Response: Represents the geographical location associated with the log entry.
/// </summary>
public class LogLocation
{
  /// <summary>
  /// The region or state of the request.
  /// </summary>
  public string? Region { get; set; }

  /// <summary>
  /// The region or state code of the request.
  /// </summary>
  public string? RegionCode { get; set; }

  /// <summary>
  /// The city of the request.
  /// </summary>
  public string? City { get; set; }

  /// <summary>
  /// The country of the request.
  /// </summary>
  public string? Country { get; set; }

  /// <summary>
  /// The continent of the request.
  /// </summary>
  public string? Continent { get; set; }

  /// <summary>
  /// The latitude of the request.
  /// </summary>
  public string? Latitude { get; set; }

  /// <summary>
  /// The longitude of the request.
  /// </summary>
  public string? Longitude { get; set; }

  /// <summary>
  /// The IANA time zone of the request.
  /// </summary>
  public string? TimeZone { get; set; }

  /// <summary>
  /// The postal or zip code of the request.
  /// </summary>
  public string? ZipCode { get; set; }
}


