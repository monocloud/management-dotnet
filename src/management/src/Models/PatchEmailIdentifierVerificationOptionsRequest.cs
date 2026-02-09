namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Email Identifier Verification Options Request: Used to update email address verification settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchEmailIdentifierVerificationOptionsRequest>))]
public class PatchEmailIdentifierVerificationOptionsRequest
{
  /// <summary>
  /// Specifies whether the user&#39;s email address must be verified during sign-up.
  /// </summary>
  public Optional<bool> VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email verification (link, code, or both).
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the email verification flow can be resumed in a different browser or device than where it was initiated.
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


