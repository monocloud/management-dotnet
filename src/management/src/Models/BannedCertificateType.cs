namespace MonoCloud.Management.Models;

/// <summary>
/// The banned certificate identifier type.
/// </summary>
public enum BannedCertificateType
{
  /// <summary>
  /// Ban by certificate thumbprint.
  /// </summary>
  Thumbprint,

  /// <summary>
  /// Ban by certificate serial number.
  /// </summary>
  SerialNumber,

  /// <summary>
  /// Ban by certificate subject.
  /// </summary>
  Subject
}


