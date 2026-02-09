namespace MonoCloud.Management.Models;

/// <summary>
/// Recovery Methods Phone Options Response: Represents the phone-based account and password recovery configuration.
/// </summary>
public class RecoveryMethodsPhoneOptions
{
  /// <summary>
  /// Enables account and password recovery using a phone-based verification code.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Specifies the validity period of the recovery verification code (in seconds).
  /// </summary>
  public int Expiry { get; set; }

  /// <summary>
  /// Specifies the number of digits in the recovery verification code.
  /// </summary>
  public int CodeLength { get; set; }
}


