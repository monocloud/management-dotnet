namespace MonoCloud.Management.Models;

/// <summary>
/// Account Protection User Unblock Email Options Response: Represents email-based configuration for allowing users to unblock their accounts after a lockout.
/// </summary>
public class AccountProtectionUserUnblockEmailOptions
{
  /// <summary>
  /// Specifies the validity period of the unblock email link (in seconds).
  /// </summary>
  public int Expiry { get; set; }
}


