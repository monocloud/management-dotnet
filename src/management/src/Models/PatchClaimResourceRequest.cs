namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Claim Request: Used to update one or more properties of an existing claim.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClaimResourceRequest>))]
public class PatchClaimResourceRequest
{
  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Indicates whether this resource is advertised via the discovery document.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// The unique name of the claim.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Specifies the expression or attribute path used to derive the claim value from the user profile or identity context.
  /// </summary>
  public Optional<string> Source { get; set; }
}


