namespace MonoCloud.Management.Models;

/// <summary>
/// Create API Resource Client Request: Creates an entry that authorizes client access to an API resource.
/// </summary>
public class CreateApiResourceClientRequest
{
  /// <summary>
  /// List of API scopes the client is explicitly allowed to access. When empty, the client is permitted to access all scopes defined for the API resource.
  /// </summary>
  public List<string> RestrictedScopes { get; set; }
}


