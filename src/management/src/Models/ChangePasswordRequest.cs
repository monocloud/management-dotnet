namespace MonoCloud.Management.Models;

/// <summary>
/// Change Password Request: Used to change a user&#39;s password, with support for plaintext or pre-hashed values.
/// </summary>
public class ChangePasswordRequest
{
  /// <summary>
  /// The new plain-text password to assign to the user.
  /// </summary>
  public string? NewPassword { get; set; }

  /// <summary>
  /// A pre-computed password hash for the new password.
  /// </summary>
  /// <warning>When provided, password validation and password policy requirements are not enforced. The hash is stored as-is.</warning>
  public string? NewPasswordHash { get; set; }

  /// <summary>
  /// Hashing algorithm used for the provided password hash.
  /// </summary>
  public PasswordAlgorithms? NewPasswordHashAlgorithm { get; set; }

  /// <summary>
  /// The user&#39;s current plain-text password used for verification.
  /// </summary>
  public string OldPassword { get; set; }

  /// <summary>
  /// A flag to indicate whether all active user sessions should be revoked when the password is updated.
  /// </summary>
  public bool? RevokeSessions { get; set; }
}


