namespace MonoCloud.Management.Models;

/// <summary>
/// Create API Resource Request: Creates a protected backend or service.
/// </summary>
public class CreateApiResourceRequest
{
  /// <summary>
  /// Indicates whether the resource is enabled.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  /// Human-readable display name for the resource.
  /// </summary>
  public string? DisplayName { get; set; }

  /// <summary>
  /// Description that explains the purpose of the resource.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Audience value that will be included in issued access tokens for this API resource.
  /// </summary>
  public string Audience { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource must be exclusive and not shared with other API resources.
  /// </summary>
  public bool? RequireExclusiveToken { get; set; }

  /// <summary>
  /// Specifies whether access tokens issued for this resource may include identity scopes, allowing them to be used with identity-related endpoints such as &#x60;UserInfo&#x60;.
  /// </summary>
  public bool? EnableIdentityAccess { get; set; }

  /// <summary>
  /// List of user claim types that will be embedded into access tokens issued for this API resource.
  /// </summary>
  public List<string> UserClaims { get; set; }

  /// <summary>
  /// Automatically generates a secure secret when the API resource is created. This secret is used by the resource to authenticate when performing token introspection.
  /// </summary>
  /// <note>ScaleX subscription required to generate API secrets.</note>
  public bool? AutoGenerateSecret { get; set; }
}


