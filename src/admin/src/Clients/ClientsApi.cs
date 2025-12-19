namespace MonoCloud.Management.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Clients Api endpoints
/// </summary>
public class ClientsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ClientsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public ClientsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ClientsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public ClientsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Find a Client by Id
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Client</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Client>> FindClientByIdAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}?");

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

    return ProcessRequestAsync<Client>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Client
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteClientAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a Client
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="patchClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Client</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Client>> PatchClientAsync(string clientId, PatchClientRequest patchClientRequest, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (patchClientRequest == null)
    {
      throw new ArgumentNullException(nameof(patchClientRequest));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Client>(request, cancellationToken);
  }

  /// <summary>
  /// Gets all client secrets
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Secret&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Secret>>> GetAllClientSecretsAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/secrets?");

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
  /// Create a Client Secret
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="createSecretRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateClientSecretAsync(string clientId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (createSecretRequest == null)
    {
      throw new ArgumentNullException(nameof(createSecretRequest));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/secrets?");

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
  /// Find a Client Secret by Id
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> FindClientSecretByIdAsync(string clientId, string secretId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/secrets/{encodedSecretId}?");

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
  /// Delete a Client Secret
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteClientSecretAsync(string clientId, string secretId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Clients
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the clients needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_name&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Client&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Client>, PageModel>> GetAllClientsAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("clients?");

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

    return ProcessRequestAsync<List<Client>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a Client
  /// </summary>
  /// <param name="createClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Client</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Client>> CreateClientAsync(CreateClientRequest createClientRequest, CancellationToken cancellationToken = default)
  {
    if (createClientRequest == null)
    {
      throw new ArgumentNullException(nameof(createClientRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("clients?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Client>(request, cancellationToken);
  }

  /// <summary>
  /// Finds a Client Group by Id
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="groupId">Group Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClientGroup</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClientGroup>> FindClientGroupAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/groups/{encodedGroupId}?");

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

    return ProcessRequestAsync<ClientGroup>(request, cancellationToken);
  }

  /// <summary>
  /// Assigns a group to a client
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="groupId">Group Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> AssignGroupToClientAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Remove a group from a client
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="groupId">Group Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveGroupFromClientAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Gets all Groups assigned to a client
  /// </summary>
  /// <param name="clientId">Client Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key value is &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ClientGroup&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ClientGroup>, PageModel>> GetAllClientGroupsAsync(string clientId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/{encodedClientId}/groups?");

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

    return ProcessRequestAsync<List<ClientGroup>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Get all Clients assigned to a Group
  /// </summary>
  /// <param name="groupId">Group Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the clients needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_name&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Client&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Client>, PageModel>> GetAllGroupAssignedClientsAsync(Guid groupId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"clients/groups/{encodedGroupId}/assigned?");

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

    return ProcessRequestAsync<List<Client>, PageModel>(request, cancellationToken);
  }
}

