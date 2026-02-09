namespace MonoCloud.Management.Models;

/// <summary>
/// Authorization Code: Represents a short-lived authorization code issued to a client.
/// </summary>
public class AuthorizationCode
{
  /// <summary>
  /// The unique identifier of the grant.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// The unique identifier of the client to which the grant was issued.
  /// </summary>
  public string ClientId { get; set; }

  /// <summary>
  /// Specifies the time at which the grant was issued (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// The unique identifier of the user session associated with this authorization code.
  /// </summary>
  public string? SessionId { get; set; }

  /// <summary>
  /// The scopes authorized by the user and associated with this authorization code.
  /// </summary>
  public List<string> AuthorizedScopes { get; set; }

  /// <summary>
  /// Specifies the time at which the authorization code expires (in Epoch).
  /// </summary>
  public DateTime? Expiration { get; set; }
}


