namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Sign-up Options Request: Used to update the sign-up configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSignUpOptionsRequest>))]
public class PatchSignUpOptionsRequest
{
  /// <summary>
  /// Show Terms and/or Privacy Policy on the sign-up screen.
  /// </summary>
  /// <note>Pro plan required to enable Terms and/or Privacy Policy.</note>
  public Optional<bool> ShowTermsAndPrivacyPolicy { get; set; }

  /// <summary>
  /// Require the user to explicitly agree to the Terms and/or Privacy Policy.
  /// </summary>
  public Optional<bool> RequireExplicitUserAgreement { get; set; }

  /// <summary>
  /// The URL of the Privacy Policy shown during sign-up.
  /// </summary>
  public Optional<string?> PrivacyUrl { get; set; }

  /// <summary>
  /// The URL of the Terms of Service shown during sign-up.
  /// </summary>
  public Optional<string?> TermsUrl { get; set; }

  /// <summary>
  /// Allowlist of identifiers permitted during sign-up.
  /// </summary>
  public Optional<PatchSignUpRestrictionsOptionsRequest> Whitelist { get; set; }

  /// <summary>
  /// Blocklist of identifiers disallowed during sign-up.
  /// </summary>
  public Optional<PatchSignUpRestrictionsOptionsRequest> Blacklist { get; set; }
}


