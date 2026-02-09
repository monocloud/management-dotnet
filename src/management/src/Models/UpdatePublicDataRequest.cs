namespace MonoCloud.Management.Models;

/// <summary>
/// Update Public Data Request: Updates public data associated with a user account.
/// </summary>
public class UpdatePublicDataRequest
{
  /// <summary>
  /// A structured payload for updating public data. Supports strings, numbers, booleans, arrays, and nested objects. Fields omitted remain unchanged; fields set to &#x60;null&#x60; are removed.
  /// </summary>
  public Dictionary<string, object> PublicData { get; set; }
}


