namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Account Protection User Lockout Options Request: Used to update user lockout behavior and thresholds.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserLockoutOptionsRequest>))]
public class PatchAccountProtectionUserLockoutOptionsRequest
{
  /// <summary>
  /// Enables user lockout protection.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Maximum failed sign-in attempts allowed before lockout (inclusive).
  /// </summary>
  public Optional<int> MaxFailedAccessAttempts { get; set; }

  /// <summary>
  /// User account lockout duration (in minutes).
  /// </summary>
  public Optional<int> UserLockoutTimeSpan { get; set; }

  /// <summary>
  /// IP lockout duration (in minutes).
  /// </summary>
  public Optional<int> IpLockoutTimeSpan { get; set; }

  /// <summary>
  /// Allowlisted IP addresses that are exempt from lockout enforcement.
  /// </summary>
  public Optional<List<string>> AllowedIps { get; set; }

  /// <summary>
  /// The lockout enforcement mode (IP-based or user-account-based).
  /// </summary>
  public Optional<UserLockoutTypes> LockoutType { get; set; }

  /// <summary>
  /// The user unblock configuration.
  /// </summary>
  public Optional<PatchAccountProtectionUserUnblockOptionsRequest> UserUnblock { get; set; }
}


