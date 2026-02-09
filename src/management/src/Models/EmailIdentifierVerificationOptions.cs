namespace MonoCloud.Management.Models;

/// <summary>
/// Email Identifier Verification Options Response: Represents email verification settings applied during sign-up.
/// </summary>
public class EmailIdentifierVerificationOptions
{
  /// <summary>
  /// Specifies whether the user&#39;s email address must be verified during sign-up.
  /// </summary>
  public bool VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email verification (link, code, or both).
  /// </summary>
  public VerificationTypes VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the email verification flow can be resumed in a different browser or device than where it was initiated.
  /// </summary>
  public bool AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the validity period of the email verification link or code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the email verification code.
  /// </summary>
  /// <note>Only applicable when the verification type includes code-based verification.</note>
  public int CodeLength { get; set; }
}


