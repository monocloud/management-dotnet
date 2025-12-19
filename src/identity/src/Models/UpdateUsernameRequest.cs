namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Update Username Request.
/// </summary>
public class UpdateUsernameRequest
{
  /// <summary>
  /// The username to assign to the user. Must comply with the configured username policy, including format and uniqueness requirements.
  /// </summary>
  public string Username { get; set; }
}


