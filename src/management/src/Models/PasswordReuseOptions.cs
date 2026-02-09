namespace MonoCloud.Management.Models;

/// <summary>
/// Password Reuse Options Response: Represents the configuration for password reuse restrictions.
/// </summary>
public class PasswordReuseOptions
{
  /// <summary>
  /// Specifies the password reuse control policy, defining whether reuse is limited by time, count, both, or unrestricted.
  /// </summary>
  public PasswordRestrictionModes RestrictionMode { get; set; }

  /// <summary>
  /// Specifies the time period during which previously used passwords are blocked from reuse (in minutes).
  /// </summary>
  public int RestrictionPeriod { get; set; }

  /// <summary>
  /// Defines the number of historical passwords that are disallowed for reuse under count-based enforcement.
  /// </summary>
  public int RestrictionCount { get; set; }
}


