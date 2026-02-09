namespace MonoCloud.Management.Models;

/// <summary>
/// User Connection: Represents the association between a user account and an identity provider.
/// </summary>
public class UserConnection
{
  /// <summary>
  /// The identity provider this user account is connected to.
  /// </summary>
  public IdPs Idp { get; set; }

  /// <summary>
  /// Unique identifier of the user account within the connected identity provider.
  /// </summary>
  public string ConnectionId { get; set; }
}


