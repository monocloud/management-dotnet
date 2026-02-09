namespace MonoCloud.Management.Models;

/// <summary>
/// API Resource Client Response: Represents a client’s authorized access to an API resource.
/// </summary>
public class ApiResourceClient
{
  /// <summary>
  /// The unique identifier of the API resource.
  /// </summary>
  public string ResourceId { get; set; }

  /// <summary>
  /// The unique identifier of the client application.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// List of API scopes the client is explicitly allowed to access. When empty, the client is permitted to access all scopes defined for the API resource.
  /// </summary>
  public List<string> RestrictedScopes { get; set; }

  /// <summary>
  /// Specifies the creation time of the client–API resource association (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the client–API resource association (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


