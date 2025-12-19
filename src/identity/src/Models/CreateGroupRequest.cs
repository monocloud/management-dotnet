namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Create Group Request class.
/// </summary>
public class CreateGroupRequest
{
  /// <summary>
  /// The display name of the group.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Optional description that indicates the purpose or role of the group.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Indicates whether new users are automatically assigned to this group upon sign-up.
  /// </summary>
  public bool? IsAutoAssigned { get; set; }
}


