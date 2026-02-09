namespace MonoCloud.Management.Models;

/// <summary>
/// User Client Grants: Represents issued grants for a user-client relationship.
/// </summary>
public class UserClientGrants
{
  /// <summary>
  /// The unique identifier of the client for which grants were issued.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// Indicates whether the user has granted consent for one or more scopes to this client.
  /// </summary>
  public bool Consented { get; set; }

  /// <summary>
  /// The number of active refresh tokens issued for this client.
  /// </summary>
  public long RefreshTokens { get; set; }

  /// <summary>
  /// The number of active reference (opaque) access tokens issued for this client.
  /// </summary>
  public long ReferenceTokens { get; set; }

  /// <summary>
  /// The number of active authorization codes issued for this client.
  /// </summary>
  public long AuthorizationCodes { get; set; }
}


