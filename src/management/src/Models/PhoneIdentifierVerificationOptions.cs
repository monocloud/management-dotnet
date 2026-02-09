namespace MonoCloud.Management.Models;

/// <summary>
/// Phone Identifier Verification Options Response: Represents phone number verification settings applied during sign-up.
/// </summary>
public class PhoneIdentifierVerificationOptions
{
  /// <summary>
  /// Specifies whether the user&#39;s phone number must be verified during sign-up.
  /// </summary>
  public bool VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the validity period of the phone verification code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the phone verification code.
  /// </summary>
  public int CodeLength { get; set; }
}


