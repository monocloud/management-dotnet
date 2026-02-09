namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Resources Api endpoints
/// </summary>
public class ResourcesClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public ResourcesClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public ResourcesClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List API resources
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of API resources. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of resources to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;display_name&#x60;, and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResource>, PageModel>> GetAllApiResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
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

    return ProcessRequestAsync<List<ApiResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an API resource
  /// </summary>
  /// <remarks>
  /// Creates a new API resource that represents a protected backend or service and can be referenced by clients to request access tokens.
  /// </remarks>>
  /// <param name="createApiResourceRequest">The request payload used to create an API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> CreateApiResourceAsync(CreateApiResourceRequest createApiResourceRequest, CancellationToken cancellationToken = default)
  {
    if (createApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an API resource
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified API resource.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> FindApiResourceByIdAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

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

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Update an API resource
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified API resource. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="patchApiResourceRequest">The request payload used to update an API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> PatchApiResourceAsync(string apiId, PatchApiResourceRequest patchApiResourceRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (patchApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an API resource
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified API resource and all API scopes defined for it.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List API resource secrets
  /// </summary>
  /// <remarks>
  /// Retrieves a list of secrets associated with the API resource.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Secret&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Secret>>> GetAllApiResourceSecretsAsync(string apiId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets?");

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

    return ProcessRequestAsync<List<Secret>>(request, cancellationToken);
  }

  /// <summary>
  /// Create an API resource secret
  /// </summary>
  /// <remarks>
  /// Creates a new secret credential for the API resource, used to authenticate the resource during token introspection.
  /// </remarks>>
  /// <note>Access to the API secret creation endpoint requires an active ScaleX subscription.</note>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="createSecretRequest">The request payload used to create an API resource secret.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateApiResourceSecretAsync(string apiId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (createSecretRequest == null)
    {
      throw new ArgumentNullException(nameof(createSecretRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createSecretRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an API resource secret
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified API resource secret.
  /// </remarks>>
  /// <param name="secretId">The unique identifier of the API resource secret.</param>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> FindApiResourceSecretByIdAsync(string secretId, string apiId, CancellationToken cancellationToken = default)
  {
    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets/{encodedSecretId}?");

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

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an API resource secret
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified API resource secret.
  /// </remarks>>
  /// <warning>This operation is irreversible. Tokens presented to this API resource can no longer be introspected using this secret.</warning>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="secretId">The unique identifier of the API resource secret.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceSecretAsync(string apiId, string secretId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List API scopes
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of API scopes for the specified API resource. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of resources to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;display_name&#x60;, and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiScope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiScope>, PageModel>> GetAllApiScopesAsync(string apiId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
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

    return ProcessRequestAsync<List<ApiScope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an API scope
  /// </summary>
  /// <remarks>
  /// Creates a new API scope for the specified API resource. An API scope represents a permission that clients may request and that determines the claims and access level included in issued access tokens.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="createApiScopeRequest">The request payload used to create an API scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> CreateApiScopeAsync(string apiId, CreateApiScopeRequest createApiScopeRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (createApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiScopeRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an API scope
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified API scope.
  /// </remarks>>
  /// <param name="scopeId">The unique identifier of the API scope.</param>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> FindApiScopeByIdAsync(string scopeId, string apiId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

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

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Update an API scope
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified API scope. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="scopeId">The unique identifier of the API scope.</param>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="patchApiScopeRequest">The request payload used to update an API scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> PatchApiScopeAsync(string scopeId, string apiId, PatchApiScopeRequest patchApiScopeRequest, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (patchApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiScopeRequest));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an API scope
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified API scope from the API resource.
  /// </remarks>>
  /// <warning>This operation is irreversible. Once deleted, clients will no longer be able to request or obtain access tokens containing this scope.</warning>
  /// <param name="scopeId">The unique identifier of the API scope.</param>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiScopeAsync(string scopeId, string apiId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List API resource client access
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of client access entries for the specified API resource. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of API–client access entries to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_id&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllApiResourceClientsAsync(string apiId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients?");

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

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List API resource access for a client
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of API resource access entries associated with the specified client. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of API–client access entries to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_id&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllClientApiResourcesAsync(string clientId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/clients/{encodedClientId}?");

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

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create API resource client access
  /// </summary>
  /// <remarks>
  /// Creates an access entry between a client and an API resource, authorizing the client to request access tokens for the resource.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="createApiResourceClientRequest">The request payload used to create an access entry authorizing the client for the API resource.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> CreateApiResourceClientAsync(string apiId, string clientId, CreateApiResourceClientRequest createApiResourceClientRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (createApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceClientRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an API resource client access entry
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for an access entry that authorizes a specific client for the specified API resource.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> FindApiResourceClientAsync(string apiId, string clientId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

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

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Update an API resource client access entry
  /// </summary>
  /// <remarks>
  /// Updates the scope restrictions for an existing client access entry.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="patchApiResourceClientRequest">The request payload used to update the client access configuration.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> PatchApiResourceClientAsync(string apiId, string clientId, PatchApiResourceClientRequest patchApiResourceClientRequest, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (patchApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceClientRequest));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Remove an API resource client access entry
  /// </summary>
  /// <remarks>
  /// Removes the access entry that authorizes the specified client to request tokens for the API resource. After removal, the client will no longer be permitted to access this API resource.
  /// </remarks>>
  /// <param name="apiId">The unique identifier of the API resource.</param>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveApiResourceClientAsync(string apiId, string clientId, CancellationToken cancellationToken = default)
  {
    if (apiId == null)
    {
      throw new ArgumentNullException(nameof(apiId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedApiId = HttpUtility.UrlEncode(apiId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedApiId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List scopes
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of identity scopes. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of resources to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;display_name&#x60;, and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Scope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Scope>, PageModel>> GetAllScopesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
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

    return ProcessRequestAsync<List<Scope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a scope
  /// </summary>
  /// <remarks>
  /// Creates a new identity scope that defines a permission clients can request to receive specific user claims.
  /// </remarks>>
  /// <param name="createScopeRequest">The request payload used to create a new scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> CreateScopeAsync(CreateScopeRequest createScopeRequest, CancellationToken cancellationToken = default)
  {
    if (createScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createScopeRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a scope
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified identity scope.
  /// </remarks>>
  /// <param name="scopeId">The unique identifier of the scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> FindScopeByIdAsync(string scopeId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

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

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Update a scope
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified identity scope. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="scopeId">The unique identifier of the scope.</param>
  /// <param name="patchScopeRequest">The request payload used to update a scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> PatchScopeAsync(string scopeId, PatchScopeRequest patchScopeRequest, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    if (patchScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchScopeRequest));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a scope
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified identity scope.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="scopeId">The unique identifier of the scope.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteScopeAsync(string scopeId, CancellationToken cancellationToken = default)
  {
    if (scopeId == null)
    {
      throw new ArgumentNullException(nameof(scopeId));
    }

    var encodedScopeId = HttpUtility.UrlEncode(scopeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedScopeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List claims
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of claims. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of resources to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;display_name&#x60;, and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ClaimResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ClaimResource>, PageModel>> GetAllClaimResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
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

    return ProcessRequestAsync<List<ClaimResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a claim
  /// </summary>
  /// <remarks>
  /// Creates a new claim that may be referenced by identity scopes to control inclusion in tokens and `UserInfo` responses.
  /// </remarks>>
  /// <param name="createClaimResourceRequest">The request payload used to create a claim.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> CreateClaimResourceAsync(CreateClaimResourceRequest createClaimResourceRequest, CancellationToken cancellationToken = default)
  {
    if (createClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createClaimResourceRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a claim
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified claim.
  /// </remarks>>
  /// <param name="claimId">The unique identifier of the claim.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> FindClaimResourceByIdAsync(string claimId, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

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

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Update a claim
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified claim. Only fields included in the request are updated.
  /// </remarks>>
  /// <note>This operation applies only to custom claims. Built-in claims cannot be modified in order to preserve OpenID Connect compliance.</note>
  /// <param name="claimId">The unique identifier of the claim.</param>
  /// <param name="patchClaimResourceRequest">The request payload used to update a claim.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> PatchClaimResourceAsync(string claimId, PatchClaimResourceRequest patchClaimResourceRequest, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    if (patchClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchClaimResourceRequest));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a claim
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified claim.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="claimId">The unique identifier of the claim.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteClaimResourceAsync(string claimId, CancellationToken cancellationToken = default)
  {
    if (claimId == null)
    {
      throw new ArgumentNullException(nameof(claimId));
    }

    var encodedClaimId = HttpUtility.UrlEncode(claimId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedClaimId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

