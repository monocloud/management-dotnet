namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Logout Options Request: Used to update logout behavior configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchLogoutOptionsRequest>))]
public class PatchLogoutOptionsRequest
{
  /// <summary>
  /// Specifies whether the user is automatically redirected to the client’s configured post-logout redirect URL after signing out.
  /// </summary>
  public Optional<bool> AutomaticRedirectAfterLogout { get; set; }

  /// <summary>
  /// Specifies whether the user is prompted for confirmation before signing out.
  /// </summary>
  public Optional<bool> ShowLogoutPrompt { get; set; }
}


