namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Set Password Request class.
/// </summary>
public class SetPasswordRequest
{
  /// <summary>
  /// Plaintext password to assign to the user.
  /// </summary>
  public string? Password { get; set; }

  /// <summary>
  /// A pre-hashed password value. Useful during migrations to avoid forcing a password reset.
  /// </summary>
  public string? PasswordHash { get; set; }

  /// <summary>
  /// The hashing algorithm used for the provided password hash.
  /// </summary>
  public PasswordAlgorithms? PasswordHashAlgorithm { get; set; }

  /// <summary>
  /// Indicates whether the provided password is temporary. If true, the user must reset their password at their next sign-in.
  /// </summary>
  public bool? IsTemporaryPassword { get; set; }

  /// <summary>
  /// Determines whether configured password policy rules should be bypassed.
  /// </summary>
  public bool? SkipPasswordPolicyChecks { get; set; }

  /// <summary>
  /// Determines whether active sessions should be revoked after updating the password.
  /// </summary>
  public bool? RevokeSessions { get; set; }
}


