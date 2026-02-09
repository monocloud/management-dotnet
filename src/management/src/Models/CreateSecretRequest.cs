namespace MonoCloud.Management.Models;

/// <summary>
/// Create Secret Request: Represents a request to create a credential used by a client or API resource.
/// </summary>
public class CreateSecretRequest
{
  /// <summary>
  /// Description that explains the purpose of the secret.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// Specifies the time at which the secret expires (in Epoch).
  /// </summary>
  public DateTime? Expiration { get; set; }

  /// <summary>
  /// Specifies the type of secret.
  /// </summary>
  public SecretTypes? Type { get; set; }

  /// <summary>
  /// The secret value used to authenticate the client or API resource.
  /// </summary>
  public string? SecretValue { get; set; }
}


