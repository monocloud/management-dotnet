namespace MonoCloud.Management.Models;

/// <summary>
/// Sign-Up Restrictions Options Response: Represents identifier-based allowlist or blocklist configuration applied during sign-up.
/// </summary>
public class SignUpRestrictionsOptions
{
  /// <summary>
  /// Indicates whether the identifier restriction list is active.
  /// </summary>
  /// <note>Pro plan subscription required to use sign-up restrictions.</note>
  public bool Enabled { get; set; }

  /// <summary>
  /// A set of identifiers (email addresses, phone numbers, or domains) used for sign-up access control.
  /// </summary>
  public List<string> Identifiers { get; set; }
}


