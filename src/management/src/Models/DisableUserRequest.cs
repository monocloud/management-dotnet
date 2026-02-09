namespace MonoCloud.Management.Models;

/// <summary>
/// Disable User Request: Defines the options used to disable an existing user account.
/// </summary>
public class DisableUserRequest
{
  /// <summary>
  /// A flag to indicate whether all active user sessions should be revoked when the account is disabled.
  /// </summary>
  public bool? RevokeSessions { get; set; }
}


