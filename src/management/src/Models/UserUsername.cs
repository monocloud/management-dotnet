namespace MonoCloud.Management.Models;

/// <summary>
/// Username: Represents a username associated with the user account.
/// </summary>
public class UserUsername
{
  /// <summary>
  /// Unique identifier of the user&#39;s username.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// The username used to identify the user.
  /// </summary>
  public string Username { get; set; }

  /// <summary>
  /// Source from which the username was originally collected.
  /// </summary>
  public string? Source { get; set; }
}


