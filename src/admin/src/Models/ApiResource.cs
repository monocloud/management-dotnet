namespace MonoCloud.Management.Admin.Models;

/// <summary>
/// The Api Resource response class
/// </summary>
public class ApiResource
{
  /// <summary>
  /// Unique ID of the Resource
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Specifies if the resource is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Display Name for the Resource
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// A brief description about the Resource
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The audience that will be added to the outgoing access token.
  /// </summary>
  public string Audience { get; set; }

  /// <summary>
  /// Specifies whether the resource requires an exclusive access token.
  /// </summary>
  public bool RequireExclusiveToken { get; set; }

  /// <summary>
  /// Specifies whether the access token for the resource can be used at the userinfo endpoint.
  /// </summary>
  public bool EnableIdentityAccess { get; set; }

  /// <summary>
  /// List of associated user claim types that should be included in the Access token.
  /// </summary>
  public List<string> UserClaims { get; set; }
}


