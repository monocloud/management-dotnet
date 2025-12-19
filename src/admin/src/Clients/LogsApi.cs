namespace MonoCloud.Management.Admin.Clients;

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
  /// Get all Log Summary
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the logs needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;time_stamp&#39;, &#39;category&#39;, &#39;code&#39;, &#39;type&#39;, and &#39;name&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;LogSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<LogSummary>, PageModel>> GetAllLogsAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
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

    return ProcessRequestAsync<List<LogSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Find a Log by Id
  /// </summary>
  /// <param name="logId">Log Id</param>
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

