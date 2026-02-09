namespace MonoCloud.Management.Models;

/// <summary>
/// Reference Token: Represents an opaque access token issued to a client.
/// </summary>
public class ReferenceToken
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
  /// The intended audiences for which this token is valid.
  /// </summary>
  public List<string> Audiences { get; set; }

  /// <summary>
  /// The issuer that generated this token.
  /// </summary>
  public string? Issuer { get; set; }
}


