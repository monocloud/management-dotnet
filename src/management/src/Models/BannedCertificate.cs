namespace MonoCloud.Management.Models;

/// <summary>
/// Banned Certificate Response: Represents a certificate that has been explicitly banned within a trust store.
/// </summary>
public class BannedCertificate
{
  /// <summary>
  /// The unique identifier of the banned certificate entry.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Specifies the identifier type used to ban the certificate.
  /// </summary>
  public BannedCertificateType Type { get; set; }

  /// <summary>
  /// The certificate identifier value used for banning.
  /// </summary>
  public string Value { get; set; }

  /// <summary>
  /// The reason explaining why the certificate was banned.
  /// </summary>
  public string? Reason { get; set; }

  /// <summary>
  /// Specifies the time at which the certificate was banned (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }
}


