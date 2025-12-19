namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Disable User Request class.
/// </summary>
public class DisableUserRequest
{
  /// <summary>
  /// Determines whether active sessions should be revoked when disabling the user.
  /// </summary>
  public bool? RevokeSessions { get; set; }
}


