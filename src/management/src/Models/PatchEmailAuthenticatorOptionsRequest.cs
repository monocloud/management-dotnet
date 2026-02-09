namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Email Authenticator Options Request: Used to partially update email-based authentication configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchEmailAuthenticatorOptionsRequest>))]
public class PatchEmailAuthenticatorOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using email-based authentication.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether new users can sign up using email-based authentication.
  /// </summary>
  public Optional<bool> EnableSignUp { get; set; }

  /// <summary>
  /// Specifies whether users can be automatically provisioned on first successful email authentication (Just-In-Time provisioning).
  /// </summary>
  public Optional<bool> EnableJitProvisioning { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email authentication (link, code, or both).
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the authentication flow can be resumed in a different browser or device than where it was initiated.
  /// </summary>
  public Optional<bool> AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the validity period of the email verification link or code (in seconds).
  /// </summary>
  /// <note>Pro plan required to customize the expiry.</note>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the email verification code.
  /// </summary>
  /// <note>Only applicable when the verification type includes code-based verification. Pro plan required to customize the code length.</note>
  public Optional<int> CodeLength { get; set; }
}


