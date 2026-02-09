namespace MonoCloud.Management.Models;

/// <summary>
/// Create Group Request: Used to create a new group.
/// </summary>
public class CreateGroupRequest
{
  /// <summary>
  /// The display name of the group.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Description that explains the purpose or role of the group.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Indicates whether users are automatically added to this group upon sign-up.
  /// </summary>
  public bool? IsAutoAssigned { get; set; }
}


