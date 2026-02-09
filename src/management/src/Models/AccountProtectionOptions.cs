namespace MonoCloud.Management.Models;

/// <summary>
/// Account Protection Options Response: Represents configuration used to protect user accounts from abuse.
/// </summary>
public class AccountProtectionOptions
{
  /// <summary>
  /// User account protection settings used to safeguard accounts from abuse.
  /// </summary>
  public AccountProtectionUserLockoutOptions UserLockout { get; set; }
}


