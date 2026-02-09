namespace MonoCloud.Management.Models;

/// <summary>
/// Create Scope Claim Request: Creates a user claim that can be included in ID tokens and the &#x60;UserInfo&#x60; endpoint when the scope is granted.
/// </summary>
public class CreateScopeClaimRequest
{
  /// <summary>
  /// The name of the user claim granted by this scope.
  /// </summary>
  public string Claim { get; set; }

  /// <summary>
  /// Indicates whether this claim is included in the issued ID token when the scope is granted.
  /// </summary>
  public bool? IncludeInIdentityToken { get; set; }

  /// <summary>
  /// Indicates whether this claim is returned by the &#x60;UserInfo&#x60; endpoint when the scope is granted.
  /// </summary>
  public bool? IncludeInUserInfo { get; set; }
}


