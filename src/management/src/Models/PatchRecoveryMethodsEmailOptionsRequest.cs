namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Email Recovery Method Options Request: Used to update email-based account and password recovery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsEmailOptionsRequest>))]
public class PatchRecoveryMethodsEmailOptionsRequest
{
  /// <summary>
  /// Enables account and password recovery using email-based verification.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email password recovery (link, code, or both).
  /// </summary>
  public Optional<VerificationTypes> VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the password recovery flow can be resumed in a different browser or device than where it was initiated.
  /// </summary>
  public Optional<bool> AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the validity period of the email recovery verification link or code (in seconds).
  /// </summary>
  /// <note>Pro plan required to customize the expiry.</note>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the email recovery verification code.
  /// </summary>
  /// <note>Only applicable when the verification type includes code-based recovery. Pro plan required to customize the code length.</note>
  public Optional<int> CodeLength { get; set; }
}


