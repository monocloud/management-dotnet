namespace MonoCloud.Management.Models;

/// <summary>
/// API Scope Response: Represents a permissioned scope that defines the level of access a client may request and that can be embedded into access tokens.
/// </summary>
public class ApiScope
{
  /// <summary>
  /// The unique identifier of the resource.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Indicates whether this API scope is advertised via the discovery document.
  /// </summary>
  public bool ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies whether the scope is mandatory and cannot be de-selected by the user on the consent screen.
  /// </summary>
  public bool Required { get; set; }

  /// <summary>
  /// Indicates whether this scope is visually emphasized on the consent screen, typically for sensitive or high-impact permissions.
  /// </summary>
  public bool Emphasize { get; set; }

  /// <summary>
  /// Specifies whether this scope is automatically included in issued tokens when the &#x60;scope&#x60; parameter is omitted.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens when this scope is granted.
  /// </summary>
  public List<string> UserClaims { get; set; }
}


