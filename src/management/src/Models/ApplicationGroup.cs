namespace MonoCloud.Management.Models;

/// <summary>
/// Application Group Response: Represents the association between an application and a group.
/// </summary>
public class ApplicationGroup
{
  /// <summary>
  /// The unique identifier of the group.
  /// </summary>
  public Guid GroupId { get; set; }

  /// <summary>
  /// The name of the group.
  /// </summary>
  public string GroupName { get; set; }

  /// <summary>
  /// Specifies the time at which the group was associated with the client (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }
}


