namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Group response class
/// </summary>
public class Group
{
  /// <summary>
  /// Unique identifier of the group.
  /// </summary>
  public Guid GroupId { get; set; }

  /// <summary>
  /// Defines the type of the group: either &#x60;custom&#x60; or &#x60;built-in&#x60;.
  /// </summary>
  public GroupTypes Type { get; set; }

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
  public bool IsAutoAssigned { get; set; }

  /// <summary>
  /// Number of users currently assigned to the group.
  /// </summary>
  public long UsersAssigned { get; set; }

  /// <summary>
  /// Number of client applications associated with the group.
  /// </summary>
  public long ClientsAssigned { get; set; }

  /// <summary>
  /// Timestamp (Unix epoch) representing when the group was created.
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Timestamp (Unix epoch) representing when the group was most recently updated.
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Timestamp (Unix epoch) representing the most recent assignment event for a user or client application.
  /// </summary>
  public DateTime LastAssigned { get; set; }
}


