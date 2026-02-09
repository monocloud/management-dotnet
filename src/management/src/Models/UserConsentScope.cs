namespace MonoCloud.Management.Models;

/// <summary>
/// User Consent Scope: Represents a scope granted by the user as part of a consent.
/// </summary>
public class UserConsentScope
{
  /// <summary>
  /// The name of the scope for which consent was granted.
  /// </summary>
  public string Scope { get; set; }

  /// <summary>
  /// Specifies the time at which consent for the scope was granted (in Epoch).
  /// </summary>
  public DateTime GrantedOn { get; set; }

  /// <summary>
  /// Specifies the time at which the granted consent expires (in Epoch).
  /// </summary>
  public DateTime? Expiration { get; set; }
}


