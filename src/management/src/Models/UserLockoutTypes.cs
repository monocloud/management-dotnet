namespace MonoCloud.Management.Models;

/// <summary>
/// The user lockout type.
/// </summary>
public enum UserLockoutTypes
{
  /// <summary>
  /// Locks out an IP address from attempting authentication for a user account.
  /// </summary>
  Ip,

  /// <summary>
  /// Locks out the user account regardless of IP address.
  /// </summary>
  UserAccount
}


