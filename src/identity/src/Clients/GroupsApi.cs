namespace MonoCloud.Management.Identity.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Groups Api endpoints
/// </summary>
public class GroupsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="GroupsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public GroupsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="GroupsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public GroupsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List all groups
  /// </summary>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of groups to return per page. The maximum allowed value is 50.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending.  Supported fields include - name, type, clients_assigned, users_assigned, last_assigned, creation_time, last_updated.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Group&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Group>, PageModel>> GetAllGroupsAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("groups?");

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

    return ProcessRequestAsync<List<Group>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a group
  /// </summary>
  /// <param name="createGroupRequest">The create group request</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Group</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Group>> CreateGroupAsync(CreateGroupRequest createGroupRequest, CancellationToken cancellationToken = default)
  {
    if (createGroupRequest == null)
    {
      throw new ArgumentNullException(nameof(createGroupRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("groups?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createGroupRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Group>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a group
  /// </summary>
  /// <param name="groupId">The unique identifier of the group</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Group</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Group>> FindGroupByIdAsync(Guid groupId, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"groups/{encodedGroupId}?");

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

    return ProcessRequestAsync<Group>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a group
  /// </summary>
  /// <param name="groupId">The unique identifier of the group to delete</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteGroupAsync(Guid groupId, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a group
  /// </summary>
  /// <param name="groupId">The unique identifier of the group</param>
  /// <param name="patchGroupRequest">The update group request.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Group</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Group>> PatchGroupAsync(Guid groupId, PatchGroupRequest patchGroupRequest, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    if (patchGroupRequest == null)
    {
      throw new ArgumentNullException(nameof(patchGroupRequest));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchGroupRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Group>(request, cancellationToken);
  }
}

