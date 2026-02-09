namespace MonoCloud.Management.Models;

/// <summary>
/// The X.509 revocation mode.
/// </summary>
public enum X509RevocationMode
{
  /// <summary>
  /// Indicates that no revocation checking is performed. Certificate revocation status is not evaluated.
  /// </summary>
  NoCheck,

  /// <summary>
  /// Indicates that revocation status is checked using online revocation mechanisms, such as Certificate Revocation Lists (CRLs) and/or OCSP responders, for the certificate chain according to the configured revocation settings.
  /// </summary>
  Online,

  /// <summary>
  /// Indicates that revocation status is checked using tenant-managed CRLs, without making external network calls.
  /// </summary>
  Offline
}


