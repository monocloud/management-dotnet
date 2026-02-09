namespace MonoCloud.Management.Models;

/// <summary>
/// Create Scope Request: Creates an identity scope that defines a permission for accessing user claims.
/// </summary>
public class CreateScopeRequest
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
  /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies whether the scope is mandatory and cannot be de-selected by the user on the consent screen.
  /// </summary>
  public bool? Required { get; set; }

  /// <summary>
  /// Indicates whether this scope is visually emphasized on the consent screen, typically for sensitive or high-impact permissions.
  /// </summary>
  public bool? Emphasize { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into identity tokens and/or returned from the &#x60;UserInfo&#x60; endpoint when this scope is granted.
  /// </summary>
  public List<CreateScopeClaimRequest> UserClaims { get; set; }
}


