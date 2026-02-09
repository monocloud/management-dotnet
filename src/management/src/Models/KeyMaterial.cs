namespace MonoCloud.Management.Models;

/// <summary>
/// Key Material Response: Represents a cryptographic key managed by the platform.
/// </summary>
public class KeyMaterial
{
  /// <summary>
  /// The unique identifier of the key material.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Specifies the cryptographic algorithm of the key material used for signing operations.
  /// </summary>
  public SigningAlgorithms SigningAlgorithm { get; set; }

  /// <summary>
  /// Indicates whether this key is the current default key used for signing operations.
  /// </summary>
  public bool IsCurrent { get; set; }

  /// <summary>
  /// Specifies the operational use of the key, defining whether it is currently permitted for token signing or limited to signature validation only.
  /// </summary>
  public KeyMaterialUses Use { get; set; }

  /// <summary>
  /// Specifies the creation time of the key (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the time from which the key material is considered valid (in Epoch).
  /// </summary>
  public DateTime ValidFrom { get; set; }

  /// <summary>
  /// Specifies the time until which the key material remains valid (in Epoch).
  /// </summary>
  public DateTime? ValidTo { get; set; }

  /// <summary>
  /// Specifies the time at which the key material was revoked (in Epoch).
  /// </summary>
  public DateTime? RevocationDate { get; set; }

  /// <summary>
  /// Specifies the time at which the key material was rotated (in Epoch).
  /// </summary>
  public DateTime? RotationDate { get; set; }
}


