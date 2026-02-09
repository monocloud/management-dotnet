namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Trust Store Request: Used to update one or more properties of an existing trust store.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchTrustStoreRequest>))]
public class PatchTrustStoreRequest
{
  /// <summary>
  /// Human-readable name for the trust store.
  /// </summary>
  public Optional<string> Name { get; set; }

  /// <summary>
  /// Indicates whether the trust store is enabled.
  /// </summary>
  public Optional<bool> Enabled { get; set; }

  /// <summary>
  /// Specifies whether this trust store’s mTLS endpoint aliases are published under &#x60;mtls_additional_endpoint_aliases&#x60; in the OpenID Connect discovery document.
  /// </summary>
  public Optional<bool> ShowInDiscoveryDocument { get; set; }

  /// <summary>
  /// PEM-encoded certificate chain (concatenated), used as the trust anchor and intermediates for mTLS validation.
  /// </summary>
  public Optional<string> CertChain { get; set; }

  /// <summary>
  /// Trust store validation settings (certificate type, revocation, caching, and related policies).
  /// </summary>
  public Optional<PatchTrustStoreOptionsRequest> Options { get; set; }
}


