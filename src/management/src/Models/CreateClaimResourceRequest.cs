namespace MonoCloud.Management.Models;

/// <summary>
/// Create Claim Resource Request: Creates a claim that defines how claim values are resolved from the identity context.
/// </summary>
public class CreateClaimResourceRequest
{
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
  public bool? ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The unique name of the claim.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies the expression or attribute path used to derive the claim value from the user profile or identity context.
  /// </summary>
  public string Source { get; set; }
}


