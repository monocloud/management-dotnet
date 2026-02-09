namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Logs Api endpoints
/// </summary>
public class LogsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="LogsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public LogsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="LogsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public LogsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List logs
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of system logs. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of logs to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;time_stamp&#x60;, &#x60;category&#x60;, &#x60;code&#x60;, &#x60;type&#x60;, and &#x60;name&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Log&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Log>, PageModel>> GetAllLogsAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("logs?");

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

    return ProcessRequestAsync<List<Log>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a log entry
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified log entry.
  /// </remarks>>
  /// <param name="logId">The unique identifier of the log entry.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Log</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Log>> FindLogByIdAsync(Guid logId, CancellationToken cancellationToken = default)
  {
    if (logId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(logId));
    }

    var encodedLogId = HttpUtility.UrlEncode(logId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"logs/{encodedLogId}?");

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

    return ProcessRequestAsync<Log>(request, cancellationToken);
  }
}

