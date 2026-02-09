namespace MonoCloud.Management.Models;

/// <summary>
/// Password Strength Options Response: Represents the configuration for password complexity and strength requirements.
/// </summary>
public class PasswordStrengthOptions
{
  /// <summary>
  /// Specifies the minimum number of characters required for a password.
  /// </summary>
  public int MinimumLength { get; set; }

  /// <summary>
  /// Specifies whether at least one non-alphanumeric character is required in the password.
  /// </summary>
  public bool RequireNonAlphanumericCharacter { get; set; }

  /// <summary>
  /// Specifies whether at least one numeric digit is required in the password.
  /// </summary>
  public bool RequireDigit { get; set; }

  /// <summary>
  /// Specifies whether at least one lowercase letter is required in the password.
  /// </summary>
  public bool RequireLowercaseCharacter { get; set; }

  /// <summary>
  /// Specifies whether at least one uppercase letter is required in the password.
  /// </summary>
  public bool RequireUppercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the minimum number of unique characters required in the password.
  /// </summary>
  public int RequiredUniqueCharactersCount { get; set; }
}


