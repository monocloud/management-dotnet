namespace MonoCloud.Management.Models;

/// <summary>
/// Create Trust Store Request: Creates a trust store used to manage trusted certificate authorities for mTLS authentication.
/// </summary>
public class CreateTrustStoreRequest
{
  /// <summary>
  /// Human-readable name for the trust store.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Specifies whether this trust store’s mTLS endpoint aliases are published under &#x60;mtls_additional_endpoint_aliases&#x60; in the OpenID Connect discovery document.
  /// </summary>
  public bool? ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// PEM-encoded certificate chain (concatenated), used as the trust anchor and intermediates for mTLS validation.
  /// </summary>
  public string CertChain { get; set; }

  /// <summary>
  /// Trust store validation settings (certificate type, revocation, caching, and related policies).
  /// </summary>
  public CreateTrustStoreOptionsRequest Options { get; set; }
}


