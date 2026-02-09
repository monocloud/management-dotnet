namespace MonoCloud.Management.Models;

/// <summary>
/// The signing algorithm.
/// </summary>
public enum SigningAlgorithms
{
  /// <summary>
  /// RSASSA-PKCS1-v1_5 using SHA-256.
  /// </summary>
  Rs256,

  /// <summary>
  /// RSASSA-PKCS1-v1_5 using SHA-384.
  /// </summary>
  Rs384,

  /// <summary>
  /// RSASSA-PKCS1-v1_5 using SHA-512.
  /// </summary>
  Rs512,

  /// <summary>
  /// RSASSA-PSS using SHA-256.
  /// </summary>
  Ps256,

  /// <summary>
  /// RSASSA-PSS using SHA-384.
  /// </summary>
  Ps384,

  /// <summary>
  /// RSASSA-PSS using SHA-512.
  /// </summary>
  Ps512,

  /// <summary>
  /// ECDSA using P-256 and SHA-256.
  /// </summary>
  Es256,

  /// <summary>
  /// ECDSA using P-384 and SHA-384.
  /// </summary>
  Es384,

  /// <summary>
  /// ECDSA using P-521 and SHA-512.
  /// </summary>
  Es512
}


