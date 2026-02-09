namespace MonoCloud.Management.Models;

/// <summary>
/// The revocation check depth.
/// </summary>
public enum RevocationCheckDepth
{
  /// <summary>
  /// Indicates that only the end-entity (leaf) certificate is checked for revocation.
  /// </summary>
  EndCertificateOnly,

  /// <summary>
  /// Indicates that all certificates in the chain except the root certificate are checked for revocation.
  /// </summary>
  ExcludeRoot,

  /// <summary>
  /// Indicates that all certificates in the chain, including the root certificate, are checked for revocation.
  /// </summary>
  EntireChain
}


