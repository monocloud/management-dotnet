namespace MonoCloud.Management.Models;

/// <summary>
/// Account Protection User Unblock Options Response: Represents configuration that controls how locked user accounts can be unblocked.
/// </summary>
public class AccountProtectionUserUnblockOptions
{
  /// <summary>
  /// Email-based user unblock configuration.
  /// </summary>
  public AccountProtectionUserUnblockEmailOptions Email { get; set; }
}


