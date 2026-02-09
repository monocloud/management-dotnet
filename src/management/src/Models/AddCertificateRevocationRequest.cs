namespace MonoCloud.Management.Models;

/// <summary>
/// Add Certificate Revocation Request: Represents a certificate revocation list (CRL) to be added to a trust store.
/// </summary>
public class AddCertificateRevocationRequest
{
  /// <summary>
  /// The certificate revocation list (CRL) in PEM format.
  /// </summary>
  public string Value { get; set; }
}


