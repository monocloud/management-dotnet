namespace MonoCloud.Management.Clients;

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
  /// List clients
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of clients. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of client applications to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_name&#x60; and &#x60;creation_time&#x60;</param>
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
  /// Create a client
  /// </summary>
  /// <remarks>
  /// Creates a new client application with the specified configuration, including redirect URIs, authentication flows, and access settings.
  /// </remarks>>
  /// <param name="createClientRequest">The request payload used to create a client.</param>
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
  /// Retrieve a client
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified client.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
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
  /// Update a client
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified client. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="patchClientRequest">The request payload used to update a client.</param>
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
  /// Delete a client
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified client.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="clientId">The unique identifier of the client.</param>
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
  /// List client secrets
  /// </summary>
  /// <remarks>
  /// Retrieves a list of secrets associated with the client.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
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
  /// Create a client secret
  /// </summary>
  /// <remarks>
  /// Creates a new secret credential for the specified client, which can be used to authenticate the client when requesting tokens.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="createSecretRequest">The request payload used to create a client secret.</param>
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
  /// Retrieve a client secret
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified client secret.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="secretId">The unique identifier of the client secret.</param>
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
  /// Delete a client secret
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified client secret.
  /// </remarks>>
  /// <warning>This operation is irreversible. Any applications using this secret will immediately fail authentication.</warning>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="secretId">The unique identifier of the client secret.</param>
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
  /// List client&#39;s groups
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of groups associated with the client. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of groups to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
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
  /// Retrieve a client group
  /// </summary>
  /// <remarks>
  /// Retrieves information about the specified group and its association with the client.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
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
  /// Assign a group to a client
  /// </summary>
  /// <remarks>
  /// Associates a group with the client and enforces group-based access control — only members of this group are permitted to access the application.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
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
  /// Remove a client from a group
  /// </summary>
  /// <remarks>
  /// Removes the specified client from the group. After removal, the group will no longer grant access or permissions to this client.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
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
  /// List clients in group
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of clients that are assigned to the specified group. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of client applications to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_name&#x60; and &#x60;creation_time&#x60;</param>
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

