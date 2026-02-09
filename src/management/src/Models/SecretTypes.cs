namespace MonoCloud.Management.Models;

/// <summary>
/// The secret type.
/// </summary>
public enum SecretTypes
{
  /// <summary>
  /// A shared symmetric secret value.
  /// </summary>
  SharedSecret,

  /// <summary>
  /// An X.509 certificate identified by its thumbprint.
  /// </summary>
  X509Thumbprint,

  /// <summary>
  /// An X.509 certificate identified by its subject name.
  /// </summary>
  X509Name,

  /// <summary>
  /// An X.509 certificate identified by its issuer name.
  /// </summary>
  X509IssuerName,

  /// <summary>
  /// A base64-encoded X.509 certificate.
  /// </summary>
  X509CertificateBase64,

  /// <summary>
  /// A JSON Web Key (JWK).
  /// </summary>
  Jwk,

  /// <summary>
  /// A shared secret used for JWT-based client assertion authentication.
  /// </summary>
  JwtAssertionSharedSecret
}


