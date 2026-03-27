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
  /// List applications
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of applications. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of client applications to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_name&#x60; and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Application&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Application>, PageModel>> GetAllApplicationsAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("applications?");

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

    return ProcessRequestAsync<List<Application>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a application
  /// </summary>
  /// <remarks>
  /// Creates a new application application with the specified configuration, including redirect URIs, authentication flows, and access settings.
  /// </remarks>>
  /// <param name="createApplicationRequest">The request payload used to create a application.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Application</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Application>> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest, CancellationToken cancellationToken = default)
  {
    if (createApplicationRequest == null)
    {
      throw new ArgumentNullException(nameof(createApplicationRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("applications?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApplicationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Application>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a application
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified application.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Application</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Application>> FindApplicationByIdAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/{encodedClientId}?");

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

    return ProcessRequestAsync<Application>(request, cancellationToken);
  }

  /// <summary>
  /// Update a application
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified application. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="patchApplicationRequest">The request payload used to update a application.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Application</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Application>> PatchApplicationAsync(string clientId, PatchApplicationRequest patchApplicationRequest, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    if (patchApplicationRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApplicationRequest));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApplicationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Application>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a application
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified application.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApplicationAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List application secrets
  /// </summary>
  /// <remarks>
  /// Retrieves a list of secrets associated with the application.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Secret&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Secret>>> GetAllApplicationSecretsAsync(string clientId, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/{encodedClientId}/secrets?");

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
  /// Create a application secret
  /// </summary>
  /// <remarks>
  /// Creates a new secret credential for the specified application, which can be used to authenticate the application when requesting tokens.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="createSecretRequest">The request payload used to create a application secret.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateApplicationSecretAsync(string clientId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/secrets?");

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
  /// Retrieve a application secret
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified application secret.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="secretId">The unique identifier of the application secret.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> FindApplicationSecretByIdAsync(string clientId, string secretId, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/secrets/{encodedSecretId}?");

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
  /// Delete a application secret
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified application secret.
  /// </remarks>>
  /// <warning>This operation is irreversible. Any applications using this secret will immediately fail authentication.</warning>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="secretId">The unique identifier of the application secret.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApplicationSecretAsync(string clientId, string secretId, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List application&#39;s groups
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of groups associated with the application. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of groups to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApplicationGroup&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApplicationGroup>, PageModel>> GetAllApplicationGroupsAsync(string clientId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/{encodedClientId}/groups?");

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

    return ProcessRequestAsync<List<ApplicationGroup>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a application group
  /// </summary>
  /// <remarks>
  /// Retrieves information about the specified group and its association with the application.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApplicationGroup</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApplicationGroup>> FindApplicationGroupAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/groups/{encodedGroupId}?");

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

    return ProcessRequestAsync<ApplicationGroup>(request, cancellationToken);
  }

  /// <summary>
  /// Assign a group to a application
  /// </summary>
  /// <remarks>
  /// Associates a group with the application and enforces group-based access control — only members of this group are permitted to access the application.
  /// </remarks>>
  /// <note>Access to this endpoint requires an active ScaleX subscription.</note>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> AssignGroupToApplicationAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Remove a application from a group
  /// </summary>
  /// <remarks>
  /// Removes the specified application from the group. After removal, the group will no longer grant access or permissions to this application.
  /// </remarks>>
  /// <param name="clientId">The unique identifier of the application.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveGroupFromApplicationAsync(string clientId, Guid groupId, CancellationToken cancellationToken = default)
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
    urlBuilder.Append($"applications/{encodedClientId}/groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List applications in group
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of applications that are assigned to the specified group. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of client applications to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;client_name&#x60; and &#x60;creation_time&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Application&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Application>, PageModel>> GetAllGroupAssignedApplicationsAsync(Guid groupId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"applications/groups/{encodedGroupId}/assigned?");

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

    return ProcessRequestAsync<List<Application>, PageModel>(request, cancellationToken);
  }
}

