namespace MonoCloud.Management.Models;

/// <summary>
/// Certificate Revocation Response: Represents a certificate revocation list (CRL) configured for offline revocation checking within a trust store.
/// </summary>
public class CertificateRevocation
{
  /// <summary>
  /// The unique identifier of the revocation entry.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// The certificate revocation list (CRL) in PEM format.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The thumbprint of the CA certificate that issued this CRL.
  /// </summary>
  public string IssuerThumbprint { get; set; }

  /// <summary>
  /// Specifies the time at which the CRL was issued (in Epoch).
  /// </summary>
  public DateTime IssuedAt { get; set; }

  /// <summary>
  /// Specifies the time at which the next CRL update is expected (in Epoch).
  /// </summary>
  public DateTime? NextUpdate { get; set; }

  /// <summary>
  /// Specifies the time at which this revocation entry was created (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Indicates the type of revocation list (base or delta).
  /// </summary>
  public string Type { get; set; }

  /// <summary>
  /// The CRL number as defined in the X.509 CRL extensions, identifying the sequence of this revocation list.
  /// </summary>
  public int? CrlNumber { get; set; }

  /// <summary>
  /// The delta CRL number, as defined in the X.509 CRL extensions, identifying the sequence number of this delta update.
  /// </summary>
  public int? DeltaCrlNumber { get; set; }

  /// <summary>
  /// The unique identifier of the base (full) revocation entry to which this delta CRL applies.
  /// </summary>
  public string? BaseRevocationId { get; set; }
}


