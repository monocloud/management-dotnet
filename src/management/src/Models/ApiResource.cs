namespace MonoCloud.Management.Models;

/// <summary>
/// API Resource Response: Represents a protected API resource and its access-token issuance configuration.
/// </summary>
public class ApiResource
{
  /// <summary>
  /// The unique identifier of the resource.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Indicates whether the resource is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies the creation time of the resource (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the resource (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// Audience value that will be included in issued access tokens for this API resource.
  /// </summary>
  public string Audience { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource must be exclusive and not shared with other API resources.
  /// </summary>
  public bool RequireExclusiveToken { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource may include identity scopes, allowing them to be used with identity-related endpoints such as &#x60;UserInfo&#x60;.
  /// </summary>
  public bool EnableIdentityAccess { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens issued for this API resource.
  /// </summary>
  public List<string> UserClaims { get; set; }
}


