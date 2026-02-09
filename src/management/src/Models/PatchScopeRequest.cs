namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Scope Request: Used to update one or more properties of an existing scope.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchScopeRequest>))]
public class PatchScopeRequest
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
  /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Specifies whether the scope is mandatory and cannot be de-selected by the user on the consent screen.
  /// </summary>
  public Optional<bool> Required { get; set; }

  /// <summary>
  /// Indicates whether this scope is visually emphasized on the consent screen, typically for sensitive or high-impact permissions.
  /// </summary>
  public Optional<bool> Emphasize { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into identity tokens and/or returned from the &#x60;UserInfo&#x60; endpoint when this scope is granted.
  /// </summary>
  public Optional<List<PatchScopeClaimRequest>> UserClaims { get; set; }
}


