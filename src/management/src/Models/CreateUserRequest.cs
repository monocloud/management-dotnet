namespace MonoCloud.Management.Models;

/// <summary>
/// Create User Request: Fields used to create a new user and optionally set identifiers, credentials, and profile attributes.
/// </summary>
public class CreateUserRequest
{
  /// <summary>
  /// Username to assign to the user. Must satisfy username policy and be unique.
  /// </summary>
  public string? Username { get; set; }

  /// <summary>
  /// Email address to add to the user account.
  /// </summary>
  public string? Email { get; set; }

  /// <summary>
  /// Marks the email as verified. Users cannot sign in with this email until it is verified.
  /// </summary>
  public bool? EmailVerified { get; set; }

  /// <summary>
  /// Phone number to add to the user account in E.164 format.
  /// </summary>
  public string? PhoneNumber { get; set; }

  /// <summary>
  /// Marks the phone number as verified. Users cannot sign in with this phone number until it is verified.
  /// </summary>
  public bool? PhoneNumberVerified { get; set; }

  /// <summary>
  /// Initial plain-text password for the user.
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
  /// Full name of the user.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Given (first) name of the user.
  /// </summary>
  public string? GivenName { get; set; }

  /// <summary>
  /// Middle name or initial of the user.
  /// </summary>
  public string? MiddleName { get; set; }

  /// <summary>
  /// Family (last) name of the user.
  /// </summary>
  public string? FamilyName { get; set; }

  /// <summary>
  /// Preferred nickname for the user.
  /// </summary>
  public string? Nickname { get; set; }

  /// <summary>
  /// URL of the user&#39;s profile image.
  /// </summary>
  public string? Picture { get; set; }

  /// <summary>
  /// Allows bypassing configured password policy checks.
  /// </summary>
  public bool? SkipPasswordPolicyChecks { get; set; }

  /// <summary>
  /// Allows bypassing blacklist validation for the provided identifiers.
  /// </summary>
  public bool? SkipIdentifierRestrictionChecks { get; set; }

  /// <summary>
  /// Allows bypassing profile conformance checks enforced by sign-up policies.
  /// </summary>
  public bool? SkipConformanceChecks { get; set; }
}


