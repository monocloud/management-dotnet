namespace MonoCloud.Management.Models;

/// <summary>
/// Revocation Grouped Delta Response: Represents a delta certificate revocation list (delta CRL) associated with a base CRL.
/// </summary>
public class RevocationGroupedDelta
{
  /// <summary>
  /// The unique identifier of the delta revocation entry.
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
  /// The base CRL number, as defined in the X.509 CRL extensions, identifying the full CRL on which this delta CRL is based.
  /// </summary>
  public int CrlNumber { get; set; }

  /// <summary>
  /// The delta CRL number, as defined in the X.509 CRL extensions, identifying the sequence number of this delta update.
  /// </summary>
  public int DeltaCrlNumber { get; set; }

  /// <summary>
  /// The unique identifier of the base (full) revocation entry to which this delta CRL applies.
  /// </summary>
  public string BaseRevocationId { get; set; }
}


