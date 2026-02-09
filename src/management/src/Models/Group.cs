namespace MonoCloud.Management.Models;

/// <summary>
/// Group: Represents a group used to organize users and client assignments.
/// </summary>
public class Group
{
  /// <summary>
  /// The unique identifier of the group.
  /// </summary>
  public Guid GroupId { get; set; }

  /// <summary>
  /// Specifies whether the group is system-defined or user-managed.
  /// </summary>
  public GroupTypes Type { get; set; }

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
  public bool IsAutoAssigned { get; set; }

  /// <summary>
  /// The number of users currently assigned to the group.
  /// </summary>
  public long UsersAssigned { get; set; }

  /// <summary>
  /// The number of client applications associated with the group.
  /// </summary>
  public long ClientsAssigned { get; set; }

  /// <summary>
  /// Specifies the time at which the group was created (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the time at which the group was last updated (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Specifies the time of the most recent user or client assignment to the group (in Epoch).
  /// </summary>
  public DateTime LastAssigned { get; set; }
}


