namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Sign-Up Restrictions Options Request: Used to update identifier-based allowlist or blocklist configuration for the sign-up flow.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSignUpRestrictionsOptionsRequest>))]
public class PatchSignUpRestrictionsOptionsRequest
{
  /// <summary>
  /// Indicates whether the identifier restriction list is active.
  /// </summary>
  /// <note>Pro plan subscription required to use sign-up restrictions.</note>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// A set of identifiers (email addresses, phone numbers, or domains) used for sign-up access control.
  /// </summary>
  public Optional<List<string>> Identifiers { get; set; }
}


