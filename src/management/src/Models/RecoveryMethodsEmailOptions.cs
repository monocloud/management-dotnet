namespace MonoCloud.Management.Models;

/// <summary>
/// Recovery Methods Email Options Response: Represents the email-based account and password recovery configuration.
/// </summary>
public class RecoveryMethodsEmailOptions
{
  /// <summary>
  /// Enables account and password recovery using email-based verification.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies the verification mechanism used for email password recovery (link, code, or both).
  /// </summary>
  public VerificationTypes VerificationType { get; set; }

  /// <summary>
  /// Specifies whether the password recovery flow can be resumed in a different browser or device than where it was initiated.
  /// </summary>
  public bool AllowCrossBrowser { get; set; }

  /// <summary>
  /// Specifies the validity period of the email recovery verification link or code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the email recovery verification code.
  /// </summary>
  /// <note>Only applicable when the verification type includes code-based recovery.</note>
  public int CodeLength { get; set; }
}


