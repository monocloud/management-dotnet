namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Phone Identifier Verification Options Request: Used to update phone number verification settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPhoneIdentifierVerificationOptionsRequest>))]
public class PatchPhoneIdentifierVerificationOptionsRequest
{
  /// <summary>
  /// Specifies whether the user&#39;s phone number must be verified during sign-up.
  /// </summary>
  public Optional<bool> VerifyAtSignUp { get; set; }

  /// <summary>
  /// Specifies the validity period of the phone verification code (in seconds).
  /// </summary>
  /// <note>Pro plan required to customize the expiry.</note>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the phone verification code.
  /// </summary>
  /// <note>Pro plan required to customize the code length.</note>
  public Optional<int> CodeLength { get; set; }
}


