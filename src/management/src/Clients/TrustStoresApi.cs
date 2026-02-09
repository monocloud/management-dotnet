namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the TrustStores Api endpoints
/// </summary>
public class TrustStoresClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public TrustStoresClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public TrustStoresClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List trust stores
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of trust stores. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of trust stores to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;TrustStoreSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<TrustStoreSummary>, PageModel>> GetAllTrustStoresAsync(int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<TrustStoreSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a trust store
  /// </summary>
  /// <remarks>
  /// Creates a new trust store used to manage trusted certificate authorities and certificate validation settings for mTLS authentication.
  /// </remarks>>
  /// <param name="createTrustStoreRequest">The request payload used to create a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> CreateTrustStoreAsync(CreateTrustStoreRequest createTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (createTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(createTrustStoreRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a trust store
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> FindTrustStoreByIdAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Update a trust store
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified trust store. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="patchTrustStoreRequest">The request payload used to update a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> PatchTrustStoreAsync(string trustStoreId, PatchTrustStoreRequest patchTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (patchTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(patchTrustStoreRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a trust store
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified trust store.
  /// </remarks>>
  /// <warning>This operation is irreversible. Any client applications relying on this trust store for mTLS authentication will immediately fail certificate validation.</warning>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteTrustStoreAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Set a trust store as the default
  /// </summary>
  /// <remarks>
  /// Marks the specified trust store as the default for mTLS authentication. This default is used when no explicit trust store is selected for an mTLS endpoint.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> SetTrustStoreDefaultAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/default?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// List certificate revocations
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of certificate revocations (offline CRLs) configured for the specified trust store. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of revocations to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;RevocationGrouped&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<RevocationGrouped>, PageModel>> GetAllRevocationsAsync(string trustStoreId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<RevocationGrouped>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a certificate revocation
  /// </summary>
  /// <remarks>
  /// Uploads and registers an offline Certificate Revocation List (CRL) for the specified trust store. The CRL is used for offline revocation checking when the trust store is configured with `RevocationMode` set to `Offline`.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="addCertificateRevocationRequest">The request payload defining the certificate revocation list (CRL) to add to the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CertificateRevocation>> AddCertificateRevocationAsync(string trustStoreId, AddCertificateRevocationRequest addCertificateRevocationRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (addCertificateRevocationRequest == null)
    {
      throw new ArgumentNullException(nameof(addCertificateRevocationRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addCertificateRevocationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<CertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a certificate revocation
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified certificate revocation (CRL) within the trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="revocationId">The unique identifier of the certificate revocation.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CertificateRevocation>> FindCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<CertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a certificate revocation
  /// </summary>
  /// <remarks>
  /// Permanently removes the specified certificate revocation (CRL) from the trust store.
  /// </remarks>>
  /// <warning>This operation is irreversible. Revocation checks will no longer include this CRL.</warning>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="revocationId">The unique identifier of the certificate revocation.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List banned certificates
  /// </summary>
  /// <remarks>
  /// Retrieves the list of client certificates that are explicitly banned for the specified trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;BannedCertificate&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<BannedCertificate>>> GetAllBannedCertificatesAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<BannedCertificate>>(request, cancellationToken);
  }

  /// <summary>
  /// Ban a certificate
  /// </summary>
  /// <remarks>
  /// Creates a banned certificate entry in the specified trust store, preventing certificates matching the provided identifier from being trusted during mTLS authentication.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banTrustStoreCertificateRequest">The request payload used to ban a certificate.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BannedCertificate</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BannedCertificate>> BanTrustStoreCertificateAsync(string trustStoreId, BanTrustStoreCertificateRequest banTrustStoreCertificateRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banTrustStoreCertificateRequest == null)
    {
      throw new ArgumentNullException(nameof(banTrustStoreCertificateRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(banTrustStoreCertificateRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BannedCertificate>(request, cancellationToken);
  }

  /// <summary>
  /// Unban a certificate
  /// </summary>
  /// <remarks>
  /// Removes a banned-certificate entry from the trust store, allowing matching certificates to be trusted again.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banId">The unique identifier of the banned certificate entry.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> UnbanTrustStoreCertificateAsync(string trustStoreId, string banId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banId == null)
    {
      throw new ArgumentNullException(nameof(banId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedBanId = HttpUtility.UrlEncode(banId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/{encodedTrustStoreId}/banned_certificates/{encodedBanId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

