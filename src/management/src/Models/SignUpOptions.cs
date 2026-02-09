namespace MonoCloud.Management.Models;

/// <summary>
/// Sign-up Options Response: Represents the sign-up configuration.
/// </summary>
public class SignUpOptions
{
  /// <summary>
  /// Show Terms and/or Privacy Policy on the sign-up screen.
  /// </summary>
  public bool ShowTermsAndPrivacyPolicy { get; set; }

  /// <summary>
  /// Require the user to explicitly agree to the Terms and/or Privacy Policy.
  /// </summary>
  public bool RequireExplicitUserAgreement { get; set; }

  /// <summary>
  /// The URL of the Privacy Policy shown during sign-up.
  /// </summary>
  public string? PrivacyUrl { get; set; }

  /// <summary>
  /// The URL of the Terms of Service shown during sign-up.
  /// </summary>
  public string? TermsUrl { get; set; }

  /// <summary>
  /// Allowlist of identifiers permitted during sign-up.
  /// </summary>
  public SignUpRestrictionsOptions Whitelist { get; set; }

  /// <summary>
  /// Blocklist of identifiers disallowed during sign-up.
  /// </summary>
  public SignUpRestrictionsOptions Blacklist { get; set; }
}


