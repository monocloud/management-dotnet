namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Branding Api endpoints
/// </summary>
public class BrandingClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="BrandingClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public BrandingClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="BrandingClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public BrandingClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Retrieve page branding options
  /// </summary>
  /// <remarks>
  /// Retrieves the current branding configuration for hosted pages, including colors and watermark settings.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PageBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PageBrandingOptions>> FindPageBrandingOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/page?");

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

    return ProcessRequestAsync<PageBrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update page branding options
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the branding configuration for hosted pages, including colors and watermark settings. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="patchPageBrandingOptionsRequest">The request payload used to update the page branding options.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PageBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PageBrandingOptions>> PatchPageBrandingOptionsAsync(PatchPageBrandingOptionsRequest patchPageBrandingOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchPageBrandingOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchPageBrandingOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/page?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchPageBrandingOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<PageBrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve email branding options
  /// </summary>
  /// <remarks>
  /// Retrieves the current email branding configuration, including subjects and delivery behavior for system-generated emails.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>EmailBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<EmailBrandingOptions>> FindEmailBrandingOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/email?");

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

    return ProcessRequestAsync<EmailBrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update email branding options
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the email branding configuration, including subjects and delivery behavior. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="patchEmailBrandingOptionsRequest">The request payload used to update the email branding options.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>EmailBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<EmailBrandingOptions>> PatchEmailBrandingOptionsAsync(PatchEmailBrandingOptionsRequest patchEmailBrandingOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchEmailBrandingOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchEmailBrandingOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/email?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchEmailBrandingOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<EmailBrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve SMS branding options
  /// </summary>
  /// <remarks>
  /// Retrieves the current SMS message templates used for system-generated notifications.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SmsBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SmsBrandingOptions>> FindSmsBrandingOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/sms?");

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

    return ProcessRequestAsync<SmsBrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update SMS branding options
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the SMS message templates used for system-generated notifications. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="patchSmsBrandingOptionsRequest">The request payload used to update the SMS branding options.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SmsBrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SmsBrandingOptions>> PatchSmsBrandingOptionsAsync(PatchSmsBrandingOptionsRequest patchSmsBrandingOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchSmsBrandingOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchSmsBrandingOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("branding/sms?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchSmsBrandingOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SmsBrandingOptions>(request, cancellationToken);
  }
}

