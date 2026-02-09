namespace MonoCloud.Management.Models;

/// <summary>
/// Patch API Resource Client Request: Used to update a client’s access configuration for an API resource.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiResourceClientRequest>))]
public class PatchApiResourceClientRequest
{
  /// <summary>
  /// List of API scopes the client is explicitly allowed to access. When empty, the client is permitted to access all scopes defined for the API resource.
  /// </summary>
  public Optional<List<string>> RestrictedScopes { get; set; }
}


