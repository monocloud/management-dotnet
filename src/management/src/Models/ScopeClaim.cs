namespace MonoCloud.Management.Models;

/// <summary>
/// Scope Claim Response: Represents a user claim granted by a scope and included in the ID token or &#x60;UserInfo&#x60; endpoint.
/// </summary>
public class ScopeClaim
{
  /// <summary>
  /// The name of the user claim granted by this scope.
  /// </summary>
  public string Claim { get; set; }

  /// <summary>
  /// Indicates whether this claim is included in the issued ID token when the scope is granted.
  /// </summary>
  public bool IncludeInIdentityToken { get; set; }

  /// <summary>
  /// Indicates whether this claim is returned by the &#x60;UserInfo&#x60; endpoint when the scope is granted.
  /// </summary>
  public bool IncludeInUserInfo { get; set; }
}


