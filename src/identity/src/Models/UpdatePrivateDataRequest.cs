namespace MonoCloud.Management.Identity.Models;

/// <summary>
/// The Update Private Data Request class.
/// </summary>
public class UpdatePrivateDataRequest
{
  /// <summary>
  /// A structured payload for updating private data. Supports strings, numbers, booleans, arrays, and nested objects.  Fields omitted remain unchanged; fields set to &#x60;null&#x60; are removed.
  /// </summary>
  public Dictionary<string, object> PrivateData { get; set; }
}


