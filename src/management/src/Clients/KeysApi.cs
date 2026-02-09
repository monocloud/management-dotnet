namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Keys Api endpoints
/// </summary>
public class KeysClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="KeysClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public KeysClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="KeysClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public KeysClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List key materials
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of active cryptographic key materials managed by the tenant. These keys may be used for signing, encryption, token issuance, or other security-related operations.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of keys to return per page.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;KeyMaterial&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<KeyMaterial>, PageModel>> GetAllKeyMaterialsAsync(int? page = 1, int? size = 10, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("keys?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
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

    return ProcessRequestAsync<List<KeyMaterial>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Rotate a key
  /// </summary>
  /// <remarks>
  /// Rotates the specified cryptographic key by generating a new key version and promoting it as the active signing key. The previous key is retained for validation to ensure continuity for previously issued tokens.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="keyId">The unique identifier of the key.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RotateKeyAsync(string keyId, CancellationToken cancellationToken = default)
  {
    if (keyId == null)
    {
      throw new ArgumentNullException(nameof(keyId));
    }

    var encodedKeyId = HttpUtility.UrlEncode(keyId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"keys/{encodedKeyId}/rotate?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke a key
  /// </summary>
  /// <remarks>
  /// Revokes the specified cryptographic key, marking it as untrusted and immediately preventing it from being used for token signing or validation.
  /// </remarks>>
  /// <warning>This operation is irreversible. Previously issued tokens that rely on this key may no longer be considered valid, depending on the validation strategy.</warning>
  /// <param name="keyId">The unique identifier of the key.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeKeyAsync(string keyId, CancellationToken cancellationToken = default)
  {
    if (keyId == null)
    {
      throw new ArgumentNullException(nameof(keyId));
    }

    var encodedKeyId = HttpUtility.UrlEncode(keyId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"keys/{encodedKeyId}/revoke?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

