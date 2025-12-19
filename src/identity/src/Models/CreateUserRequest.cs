namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Create User Request class.
/// </summary>
public class CreateUserRequest
{
  /// <summary>
  /// The username to assign to the user. Must comply with the configured username policy, including format and uniqueness requirements.
  /// </summary>
  public string? Username { get; set; }

  /// <summary>
  /// The user’s email address.
  /// </summary>
  public string? Email { get; set; }

  /// <summary>
  /// Indicates whether the email should be marked as verified when added. If false, verification may be required before the email can be used in login or recovery flows.
  /// </summary>
  public bool? EmailVerified { get; set; }

  /// <summary>
  /// The phone number to add to the user’s account, provided in E.164 format (e.g., +14085551234).
  /// </summary>
  public string? PhoneNumber { get; set; }

  /// <summary>
  /// Indicates whether the phone number should be marked as verified when added. If false, verification may be required before the number can be used in login or recovery flows.
  /// </summary>
  public bool? PhoneNumberVerified { get; set; }

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
  /// Full name of the user.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// The user&#39;s given (first) name.
  /// </summary>
  public string? GivenName { get; set; }

  /// <summary>
  /// The user&#39;s middle name or initial, if applicable.
  /// </summary>
  public string? MiddleName { get; set; }

  /// <summary>
  /// The user&#39;s family (last) name.
  /// </summary>
  public string? FamilyName { get; set; }

  /// <summary>
  /// The user&#39;s preferred nickname.
  /// </summary>
  public string? Nickname { get; set; }

  /// <summary>
  /// URL of the user’s profile image.
  /// </summary>
  public string? Picture { get; set; }

  /// <summary>
  /// Determines whether configured password policy rules should be bypassed.
  /// </summary>
  public bool? SkipPasswordPolicyChecks { get; set; }

  /// <summary>
  /// Skips blacklist validation for the provided identifiers.
  /// </summary>
  public bool? SkipIdentifierRestrictionChecks { get; set; }

  /// <summary>
  /// Bypasses profile validation rules, such as required fields enforced during signup.
  /// </summary>
  public bool? SkipConformanceChecks { get; set; }
}


