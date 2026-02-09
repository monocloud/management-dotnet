namespace MonoCloud.Management.Models;

/// <summary>
/// Account Protection User Lockout Options Response: Represents configuration for locking user accounts after repeated failed authentication attempts.
/// </summary>
public class AccountProtectionUserLockoutOptions
{
  /// <summary>
  /// Enables user lockout protection.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Maximum failed sign-in attempts allowed before lockout (inclusive).
  /// </summary>
  public int MaxFailedAccessAttempts { get; set; }

  /// <summary>
  /// User account lockout duration (in minutes).
  /// </summary>
  public int UserLockoutTimeSpan { get; set; }

  /// <summary>
  /// IP lockout duration (in minutes).
  /// </summary>
  public int IpLockoutTimeSpan { get; set; }

  /// <summary>
  /// Allowlisted IP addresses that are exempt from lockout enforcement.
  /// </summary>
  public List<string> AllowedIps { get; set; }

  /// <summary>
  /// The lockout enforcement mode (IP-based or user-account-based).
  /// </summary>
  public UserLockoutTypes LockoutType { get; set; }

  /// <summary>
  /// The user unblock configuration.
  /// </summary>
  public AccountProtectionUserUnblockOptions UserUnblock { get; set; }
}


