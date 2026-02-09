namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Phone Recovery Method Options Request: Used to update phone-based account and password recovery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsPhoneOptionsRequest>))]
public class PatchRecoveryMethodsPhoneOptionsRequest
{
  /// <summary>
  /// Enables account and password recovery using a phone-based verification code.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies the validity period of the recovery verification code (in seconds).
  /// </summary>
  /// <note>Pro plan required to customize the expiry.</note>
  public Optional<int> Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the recovery verification code.
  /// </summary>
  /// <note>Pro plan required to customize the code length.</note>
  public Optional<int> CodeLength { get; set; }
}


