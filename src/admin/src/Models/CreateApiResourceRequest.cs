namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Create Api Resource class models an OpenID Connect or OAuth 2.0 api resource
/// </summary>
public class CreateApiResourceRequest
{
  /// <summary>
  /// Specifies if the resource is enabled.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The audience that will be added to the outgoing access token.
  /// </summary>
  public string Audience { get; set; }

  /// <summary>
  /// Specifies whether the resource requires an exclusive access token.
  /// </summary>
  public bool? RequireExclusiveToken { get; set; }

  /// <summary>
  /// Specifies whether the access token for the resource can be used at the userinfo endpoint.
  /// </summary>
  public bool? EnableIdentityAccess { get; set; }

  /// <summary>
  /// List of associated user claim types that should be included in the Access token.
  /// </summary>
  public List<string> UserClaims { get; set; }

  /// <summary>
  /// Specifies whether to auto-generate an API secret.
  /// </summary>
  public bool? AutoGenerateSecret { get; set; }
}


