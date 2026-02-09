namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Trust Store Options Request: Used to update one or more configuration properties of an existing trust store.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchTrustStoreOptionsRequest>))]
public class PatchTrustStoreOptionsRequest
{
  /// <summary>
  /// Indicates whether the client certificate is validated for client authentication, including Client Authentication EKU checks across the certificate chain.
  /// </summary>
  public Optional<bool> ValidateCertificateUse { get; set; }

  /// <summary>
  /// Indicates whether the certificate validity period (&#x60;NotBefore&#x60; / &#x60;NotAfter&#x60;) is enforced.
  /// </summary>
  public Optional<bool> ValidateValidityPeriod { get; set; }

  /// <summary>
  /// Specifies how certificate revocation status is evaluated.
  /// </summary>
  public Optional<X509RevocationMode> RevocationMode { get; set; }

  /// <summary>
  /// Specifies how revocation checks are applied across the certificate chain.
  /// </summary>
  public Optional<RevocationCheckDepth> RevocationCheckDepth { get; set; }

  /// <summary>
  /// Specifies the allowed clock skew used when validating CRL issuance times and OCSP responses (in seconds).
  /// </summary>
  public Optional<int> RevocationCheckClockSkew { get; set; }

  /// <summary>
  /// Specifies the timeout for OCSP responder calls when online revocation checking is enabled (in seconds).
  /// </summary>
  public Optional<int> OcspCheckTimeout { get; set; }

  /// <summary>
  /// Specifies the timeout for downloading CRLs from certificate distribution points (CDPs) when online revocation checking is enabled (in seconds).
  /// </summary>
  public Optional<int> OnlineCrlCheckTimeout { get; set; }

  /// <summary>
  /// Specifies how long certificate authentication results are cached (in seconds).
  /// </summary>
  public Optional<int> CertificateAuthCacheDuration { get; set; }

  /// <summary>
  /// Specifies how long OCSP responses are cached when online OCSP checking is enabled (in seconds).
  /// </summary>
  public Optional<int> OcspCacheDuration { get; set; }

  /// <summary>
  /// Specifies how long downloaded CRLs are cached when online CRL checking is enabled (in seconds).
  /// </summary>
  public Optional<int> OnlineCrlCacheDuration { get; set; }
}


