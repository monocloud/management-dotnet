namespace MonoCloud.Management.Models;

/// <summary>
/// User Consent: Represents a consent grant issued by a user to a specific client.
/// </summary>
public class UserConsent
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
  /// The consented scopes.
  /// </summary>
  public List<UserConsentScope> Scopes { get; set; }
}


