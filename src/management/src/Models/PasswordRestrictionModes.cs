namespace MonoCloud.Management.Models;

/// <summary>
/// The password restriction mode.
/// </summary>
public enum PasswordRestrictionModes
{
  /// <summary>
  /// No password reuse restrictions are enforced.
  /// </summary>
  Off,

  /// <summary>
  /// Prevents reuse of passwords used within a specified time window.
  /// </summary>
  Date,

  /// <summary>
  /// Prevents reuse of the most recently used passwords, based on a configured count.
  /// </summary>
  Count,

  /// <summary>
  /// Prevents reuse of passwords based on both a time window and a usage count.
  /// </summary>
  DateAndCount
}


