namespace MonoCloud.Management.Models;

/// <summary>
/// User Group: Represents the membership of a user in a group.
/// </summary>
public class UserGroup
{
  /// <summary>
  /// The unique identifier of the group.
  /// </summary>
  public Guid GroupId { get; set; }

  /// <summary>
  /// The unique identifier of the user.
  /// </summary>
  public string UserId { get; set; }

  /// <summary>
  /// Specifies the time at which the user was added to the group (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// The name of the group.
  /// </summary>
  public string GroupName { get; set; }
}


