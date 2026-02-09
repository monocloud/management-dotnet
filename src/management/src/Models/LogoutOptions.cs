namespace MonoCloud.Management.Models;

/// <summary>
/// Logout Options Response: Represents the current logout behavior configuration.
/// </summary>
public class LogoutOptions
{
  /// <summary>
  /// Specifies whether the user is automatically redirected to the client’s configured post-logout redirect URL after signing out.
  /// </summary>
  public bool AutomaticRedirectAfterLogout { get; set; }

  /// <summary>
  /// Specifies whether the user is prompted for confirmation before signing out.
  /// </summary>
  public bool ShowLogoutPrompt { get; set; }
}


