namespace MonoCloud.Management.Models;

/// <summary>
/// Update Username Request: Used to add a new username or update the existing one for a user account.
/// </summary>
public class UpdateUsernameRequest
{
  /// <summary>
  /// The username to assign to the user. Must comply with the configured username policy, including format and uniqueness requirements.
  /// </summary>
  public string Username { get; set; }
}


