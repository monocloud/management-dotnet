namespace MonoCloud.Management.Models;

/// <summary>
/// Trust Store Summary Response: A lightweight representation of a trust store used for mTLS authentication, returned in list operations.
/// </summary>
public class TrustStoreSummary
{
  /// <summary>
  /// The unique identifier of the trust store.
  /// </summary>
  public string Id { get; set; }

  /// <summary>
  /// Human-readable name for the trust store.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Indicates whether the trust store is enabled.
  /// </summary>
  public bool Enabled { get; set; }

  /// <summary>
  /// Indicates whether this trust store is configured as the default store for the mTLS endpoint.
  /// </summary>
  public bool IsDefault { get; set; }

  /// <summary>
  /// The total number of certificates contained in the trust store.
  /// </summary>
  public int CertificateCount { get; set; }

  /// <summary>
  /// The total number of certificates explicitly marked as banned in the trust store.
  /// </summary>
  public int BannedCertificatesCount { get; set; }

  /// <summary>
  /// Specifies the creation time of the trust store (in Epoch).
  /// </summary>
  public DateTime CreationTime { get; set; }

  /// <summary>
  /// Specifies the last update time of the trust store (in Epoch).
  /// </summary>
  public DateTime LastUpdated { get; set; }
}


