namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Password Strength Options Request: Used to partially update password complexity and strength requirements.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPasswordStrengthOptionsRequest>))]
public class PatchPasswordStrengthOptionsRequest
{
  /// <summary>
  /// Specifies the minimum number of characters required for a password.
  /// </summary>
  public Optional<int> MinimumLength { get; set; }

  /// <summary>
  /// Specifies whether at least one non-alphanumeric character is required in the password.
  /// </summary>
  public Optional<bool> RequireNonAlphanumericCharacter { get; set; }

  /// <summary>
  /// Specifies whether at least one numeric digit is required in the password.
  /// </summary>
  public Optional<bool> RequireDigit { get; set; }

  /// <summary>
  /// Specifies whether at least one lowercase letter is required in the password.
  /// </summary>
  public Optional<bool> RequireLowercaseCharacter { get; set; }

  /// <summary>
  /// Specifies whether at least one uppercase letter is required in the password.
  /// </summary>
  public Optional<bool> RequireUppercaseCharacter { get; set; }

  /// <summary>
  /// Specifies the minimum number of unique characters required in the password.
  /// </summary>
  public Optional<int> RequiredUniqueCharactersCount { get; set; }
}


