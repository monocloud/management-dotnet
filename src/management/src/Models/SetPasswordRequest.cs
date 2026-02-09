namespace MonoCloud.Management.Models;

/// <summary>
/// Set Password Request: Used to set or update a user&#39;s password, with support for plaintext or pre-hashed values.
/// </summary>
public class SetPasswordRequest
{
  /// <summary>
  /// Plain-text password to assign to the user.
  /// </summary>
  public string? Password { get; set; }

  /// <summary>
  /// A pre-hashed password value. Useful during migrations to avoid forcing a password reset.
  /// </summary>
  public string? PasswordHash { get; set; }

  /// <summary>
  /// Hashing algorithm used for the provided password hash.
  /// </summary>
  public PasswordAlgorithms? PasswordHashAlgorithm { get; set; }

  /// <summary>
  /// Indicates whether the provided password is temporary. If true, the user must reset their password at their next sign-in.
  /// </summary>
  public bool? IsTemporaryPassword { get; set; }

  /// <summary>
  /// Allows bypassing configured password policy checks.
  /// </summary>
  public bool? SkipPasswordPolicyChecks { get; set; }

  /// <summary>
  /// A flag to indicate whether all active user sessions should be revoked when the password is updated.
  /// </summary>
  public bool? RevokeSessions { get; set; }
}


