namespace MonoCloud.Management.Models;

/// <summary>
/// User Private Data: Returns private data stored for a user.
/// </summary>
public class UserPrivateData
{
  /// <summary>
  /// The private data associated with the user&#39;s account.
  /// </summary>
  public Dictionary<string, object> PrivateData { get; set; }
}


