namespace MonoCloud.Management.Models;

/// <summary>
/// Refresh Token: Represents a long-lived refresh token issued to a client.
/// </summary>
public class RefreshToken
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
  /// The unique identifier of the user session associated with this token.
  /// </summary>
  public string? SessionId { get; set; }

  /// <summary>
  /// The scopes granted to this token.
  /// </summary>
  public List<string> Scopes { get; set; }

  /// <summary>
  /// Specifies the time at which the token expires (in Epoch).
  /// </summary>
  public DateTime? Expiration { get; set; }

  /// <summary>
  /// The intended audiences for which access tokens may be issued using this refresh token.
  /// </summary>
  public List<string> Audiences { get; set; }

  /// <summary>
  /// The issuer that generated this token.
  /// </summary>
  public string? Issuer { get; set; }
}


