namespace MonoCloud.Management.Models;

/// <summary>
/// Ban Trust Store Certificate Request: Defines a certificate identifier to be banned from mTLS authentication within a trust store.
/// </summary>
public class BanTrustStoreCertificateRequest
{
  /// <summary>
  /// Specifies the identifier type used to ban the certificate.
  /// </summary>
  public BannedCertificateType? Type { get; set; }

  /// <summary>
  /// The certificate identifier value used for banning.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The reason explaining why the certificate was banned.
  /// </summary>
  public string? Reason { get; set; }
}


