namespace MonoCloud.Management.Models;

/// <summary>
/// Secret Response: Represents a credential used by a client or API resource.
/// </summary>
public class Secret
{
  /// <summary>
  /// The unique identifier of the secret.
  /// </summary>
  public string Id { get; set; }

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
  public SecretTypes Type { get; set; }

  /// <summary>
  /// Specifies the creation time of the secret (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the secret (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }

  /// <summary>
  /// The secret value used to authenticate the client or API resource.
  /// </summary>
  public string SecretValue { get; set; }
}


