namespace MonoCloud.Management.Models;

/// <summary>
/// Update Private Data Request: Updates private data associated with a user account.
/// </summary>
public class UpdatePrivateDataRequest
{
  /// <summary>
  /// A structured payload for updating private data. Supports strings, numbers, booleans, arrays, and nested objects. Fields omitted remain unchanged; fields set to &#x60;null&#x60; are removed.
  /// </summary>
  public Dictionary<string, object> PrivateData { get; set; }
}


