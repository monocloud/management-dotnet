namespace MonoCloud.Management.Models;

/// <summary>
/// User Passkey: Represents a registered passkey used for passwordless authentication by the user.
/// </summary>
public class UserPasskey
{
  /// <summary>
  /// Human-readable name assigned to the passkey.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Unique identifier of the passkey as provided by the authenticator.
  /// </summary>
  public string PasskeyId { get; set; }

  /// <summary>
  /// Public key material associated with the passkey.
  /// </summary>
  public string PublicKey { get; set; }

  /// <summary>
  /// Authenticator Attestation GUID (AAGUID) identifying the authenticator model.
  /// </summary>
  public Guid AaGuid { get; set; }

  /// <summary>
  /// Indicates whether the passkey is currently backed up by the authenticator.
  /// </summary>
  public bool BackupState { get; set; }

  /// <summary>
  /// Indicates whether the passkey is eligible for backup and multi-device use.
  /// </summary>
  public bool BackupEligibility { get; set; }

  /// <summary>
  /// Indicates whether user presence was verified during passkey authentication.
  /// </summary>
  public bool UserPresent { get; set; }

  /// <summary>
  /// Indicates whether user verification (such as biometrics or PIN) was performed during authentication.
  /// </summary>
  public bool UserVerified { get; set; }

  /// <summary>
  /// User agent of the device used to register the passkey.
  /// </summary>
  public string UserAgent { get; set; }
}


