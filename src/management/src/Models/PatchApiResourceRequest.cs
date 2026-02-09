namespace MonoCloud.Management.Models;

/// <summary>
/// Patch API Resource Request: Used to update one or more properties of an existing API resource.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiResourceRequest>))]
public class PatchApiResourceRequest
{
  /// <summary>
  /// Indicates whether the resource is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public Optional<string?> DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public Optional<string?> Description { get; set; }

  /// <summary>
  /// Audience value that will be included in issued access tokens for this API resource.
  /// </summary>
  public Optional<string> Audience { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource must be exclusive and not shared with other API resources.
  /// </summary>
  public Optional<bool> RequireExclusiveToken { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource may include identity scopes, allowing them to be used with identity-related endpoints such as &#x60;UserInfo&#x60;.
  /// </summary>
  public Optional<bool> EnableIdentityAccess { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens issued for this API resource.
  /// </summary>
  public Optional<List<string>> UserClaims { get; set; }
}


