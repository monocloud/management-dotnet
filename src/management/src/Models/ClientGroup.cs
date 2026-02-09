namespace MonoCloud.Management.Models;

/// <summary>
/// Client Group Response: Represents the association between a client and a group.
/// </summary>
public class ClientGroup
{
  /// <summary>
  /// The unique identifier of the client.
  /// </summary>
  public string ClientId { get; set; }

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


