namespace MonoCloud.Management.Models;

/// <summary>
/// User Public Data: Returns public data stored for a user.
/// </summary>
public class UserPublicData
{
  /// <summary>
  /// The public data associated with the user&#39;s account.
  /// </summary>
  public Dictionary<string, object> PublicData { get; set; }
}


