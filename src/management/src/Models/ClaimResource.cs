namespace MonoCloud.Management.Models;

/// <summary>
/// Claim Response: Represents a claim that may be included in identity tokens, access tokens, or &#x60;UserInfo&#x60; responses.
/// </summary>
public class ClaimResource
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
  /// Indicates whether this resource is advertised via the discovery document.
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
  /// The unique name of the claim.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies the expression or attribute path used to derive the claim value from the user profile or identity context.
  /// </summary>
  public string Source { get; set; }

  /// <summary>
  /// Indicates whether this claim is a built-in (system-defined) claim.
  /// </summary>
  public bool IsDefault { get; set; }
}


