namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Users Api endpoints
/// </summary>
public class UsersClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="UsersClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public UsersClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="UsersClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public UsersClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List users
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of users. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of users to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;failure_count&#x60;, &#x60;last_sign_in_attempt&#x60;, &#x60;sign_in_attempts_count&#x60;, &#x60;last_sign_in_success&#x60;, &#x60;sign_in_success_count&#x60;, &#x60;last_activity&#x60;, &#x60;block_until&#x60;, &#x60;creation_time&#x60;, &#x60;last_updated&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserSummary>, PageModel>> GetAllUsersAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("users?");

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

    return ProcessRequestAsync<List<UserSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a user
  /// </summary>
  /// <remarks>
  /// Creates a new user using identifiers such as email, phone number, or username, with an optional password or imported password hash. This endpoint also supports migration scenarios by allowing administrators to preserve verification states and bypass password policies or identifier restrictions when required.
  /// </remarks>>
  /// <note>Configured sign-up policies are enforced by default; however, this allows authorized requests to override them when permitted.</note>
  /// <param name="createUserRequest">The request payload used to create a user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> CreateUserAsync(CreateUserRequest createUserRequest, CancellationToken cancellationToken = default)
  {
    if (createUserRequest == null)
    {
      throw new ArgumentNullException(nameof(createUserRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("users?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createUserRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a user
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified user.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> FindUserByIdAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a user
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified user.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteUserAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Enable a user
  /// </summary>
  /// <remarks>
  /// Re-enables a disabled user, restoring their ability to sign-in and access connected applications.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> EnableUserAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/enable?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Disable a user
  /// </summary>
  /// <remarks>
  /// Marks the user account as disabled, preventing sign-in and access to connected applications. Optionally, active sessions can be revoked and existing opaque tokens invalidated, signing the user out immediately across all devices.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="disableUserRequest">The request payload used to disable a user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> DisableUserAsync(string userId, DisableUserRequest disableUserRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (disableUserRequest == null)
    {
      throw new ArgumentNullException(nameof(disableUserRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/disable?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(disableUserRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Reset user lockout
  /// </summary>
  /// <remarks>
  /// Resets the lockout triggered by excessive failed sign-in attempts, allowing the user to authenticate again.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> UnblockUserAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/unblock?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Add or update username
  /// </summary>
  /// <remarks>
  /// Assigns or updates the username for the user, enabling username-based authentication when applicable.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="updateUsernameRequest">The request payload used to add or update the username.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> UpdateUsernameAsync(string userId, UpdateUsernameRequest updateUsernameRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (updateUsernameRequest == null)
    {
      throw new ArgumentNullException(nameof(updateUsernameRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/username?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(updateUsernameRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Remove a username
  /// </summary>
  /// <remarks>
  /// Removes the username from the user's account. Once removed, the user will no longer be able to authenticate using a username.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> RemoveUsernameAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/username?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Add an email address
  /// </summary>
  /// <remarks>
  /// Adds a new email address to the user profile. Optional parameters allow specifying whether the email should be marked as verified.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="addEmailRequest">The request payload used to add an email address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> AddEmailAsync(string userId, AddEmailRequest addEmailRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (addEmailRequest == null)
    {
      throw new ArgumentNullException(nameof(addEmailRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addEmailRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Remove an email address
  /// </summary>
  /// <remarks>
  /// Removes the specified email address from the user’s account. Once removed, it is no longer available for authentication, verification or communication.
  /// </remarks>>
  /// <note>Removing an email may affect flows that depend on it, such as password recovery or notification delivery.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the email address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> RemoveEmailAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails/{encodedIdentifierId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Set an email as primary
  /// </summary>
  /// <remarks>
  /// Marks the specified email address as the user's primary email, making it the default for authentication, recovery, and communication.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the email address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPrimaryEmailAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails/{encodedIdentifierId}/primary?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Mark an email as verified
  /// </summary>
  /// <remarks>
  /// Marks the specified email address as verified, allowing its use for authentication, sensitive actions, and communication.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the email address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetEmailVerifiedAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails/{encodedIdentifierId}/verify?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Mark an email as unverified
  /// </summary>
  /// <remarks>
  /// Marks the specified email address as unverified, preventing its use for authentication or any other security-sensitive actions until it is verified again.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the email address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetEmailUnverifiedAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails/{encodedIdentifierId}/unverify?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Initiate email verification
  /// </summary>
  /// <remarks>
  /// Generates a signed, time-bound verification link for the specified email address and sends it to the user. Once verified, the email becomes eligible for authentication and secure communication.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the email address.</param>
  /// <param name="verifyEmailRequest">The request payload used to initiate email verification.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>VerifyEmailResponse</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<VerifyEmailResponse>> VerifyEmailAsync(string userId, Guid identifierId, VerifyEmailRequest verifyEmailRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    if (verifyEmailRequest == null)
    {
      throw new ArgumentNullException(nameof(verifyEmailRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/emails/{encodedIdentifierId}/verify/link?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(verifyEmailRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<VerifyEmailResponse>(request, cancellationToken);
  }

  /// <summary>
  /// Add a phone number
  /// </summary>
  /// <remarks>
  /// Adds a new phone number to the user profile. Optional parameters allow specifying whether the number should be marked as verified.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="addPhoneRequest">The request payload used to add a phone number.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> AddPhoneAsync(string userId, AddPhoneRequest addPhoneRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (addPhoneRequest == null)
    {
      throw new ArgumentNullException(nameof(addPhoneRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/phones?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addPhoneRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Remove a phone number
  /// </summary>
  /// <remarks>
  /// Removes the specified phone number from the user’s account. Once removed, it is no longer available for authentication, verification or communication.
  /// </remarks>>
  /// <note>Removing a phone number may affect flows that depend on it, such as password recovery or notification delivery.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the phone number.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> RemovePhoneAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/phones/{encodedIdentifierId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Set a phone as primary
  /// </summary>
  /// <remarks>
  /// Marks the specified phone number as the user's primary number, making it the default for authentication and verification.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the phone number.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPrimaryPhoneAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/phones/{encodedIdentifierId}/primary?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Mark a phone as verified
  /// </summary>
  /// <remarks>
  /// Marks the specified phone number as verified, allowing its use for authentication and other security-sensitive actions.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the phone number.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPhoneVerifiedAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/phones/{encodedIdentifierId}/verify?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Mark a phone as unverified
  /// </summary>
  /// <remarks>
  /// Marks the specified phone number as unverified, preventing its use for authentication or any other security-sensitive actions until it is verified again.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="identifierId">The unique identifier of the phone number.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPhoneUnverifiedAsync(string userId, Guid identifierId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (identifierId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(identifierId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedIdentifierId = HttpUtility.UrlEncode(identifierId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/phones/{encodedIdentifierId}/unverify?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Remove a passkey
  /// </summary>
  /// <remarks>
  /// Removes a passkey previously registered by the user. Once removed, the user will no longer be able to authenticate using that passkey.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="passkeyId">The unique identifier of the passkey.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemovePasskeyAsync(string userId, string passkeyId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (passkeyId == null)
    {
      throw new ArgumentNullException(nameof(passkeyId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedPasskeyId = HttpUtility.UrlEncode(passkeyId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/passkeys/{encodedPasskeyId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Set a password
  /// </summary>
  /// <remarks>
  /// Sets or replaces the user's password. Accepts either plaintext input or a pre-computed hash generated with a supported algorithm.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="setPasswordRequest">The request payload used to set the user&#39;s password.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPasswordAsync(string userId, SetPasswordRequest setPasswordRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (setPasswordRequest == null)
    {
      throw new ArgumentNullException(nameof(setPasswordRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/password?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PUT"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(setPasswordRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Remove the user&#39;s password
  /// </summary>
  /// <remarks>
  /// Removes the password from the specified user’s account. Once removed, the user will no longer be able to authenticate using a password until a new one is set.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemovePasswordAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/password?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Require password reset
  /// </summary>
  /// <remarks>
  /// Enforces a requirement for the user to reset their password at their next password-based sign-in.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> SetPasswordResetRequiredAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/password/force_reset?");

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

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Clear a password reset requirement
  /// </summary>
  /// <remarks>
  /// Clears the enforced password reset requirement for the user's next password-based authentication attempt.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> RemovePasswordResetRequiredAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/password/force_reset?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Initiate password reset
  /// </summary>
  /// <remarks>
  /// Generates a secure, time-bound password reset link for the specified user. The link may be delivered directly to the user or returned for custom distribution.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="resetPasswordRequest">The request payload used to generate a password reset link.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ResetPasswordResponse</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ResetPasswordResponse>> ResetPasswordAsync(string userId, ResetPasswordRequest resetPasswordRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (resetPasswordRequest == null)
    {
      throw new ArgumentNullException(nameof(resetPasswordRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/password/reset?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(resetPasswordRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ResetPasswordResponse>(request, cancellationToken);
  }

  /// <summary>
  /// Update user claims
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the claim values associated with the specified user. Only the claims provided in the request are modified. Claims can be removed by sending a `null` value for the corresponding key.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="updateClaimsRequest">The request payload used to update user claims.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> PatchClaimsAsync(string userId, UpdateClaimsRequest updateClaimsRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (updateClaimsRequest == null)
    {
      throw new ArgumentNullException(nameof(updateClaimsRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/claims?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(updateClaimsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve user private data
  /// </summary>
  /// <remarks>
  /// Retrieves the private data associated with the specified user.
  /// </remarks>>
  /// <note>Private data contains sensitive or internal attributes intended only for trusted backend services. It should not be exposed directly to client applications or included in user-visible contexts.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserPrivateData</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserPrivateData>> GetPrivateDataAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/private_data?");

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

    return ProcessRequestAsync<UserPrivateData>(request, cancellationToken);
  }

  /// <summary>
  /// Update user private data
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the private data associated with the specified user. Only fields included in the request are updated. Private data fields can be removed by sending a `null` value for the corresponding key.
  /// </remarks>>
  /// <warning>Intended for sensitive or internal-use attributes. Avoid exposing these values to client applications. If surfaced via custom claims, include them only in tokens issued to trusted backend services to prevent accidental disclosure.</warning>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="updatePrivateDataRequest">The request payload used to update a user&#39;s private data.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserPrivateData</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserPrivateData>> PatchPrivateDataAsync(string userId, UpdatePrivateDataRequest updatePrivateDataRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (updatePrivateDataRequest == null)
    {
      throw new ArgumentNullException(nameof(updatePrivateDataRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/private_data?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(updatePrivateDataRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<UserPrivateData>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve user public data
  /// </summary>
  /// <remarks>
  /// Retrieves the public data associated with the specified user.
  /// </remarks>>
  /// <note>Public data contains non-sensitive attributes that can be safely exposed to client applications and may be used to personalize user experiences.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserPublicData</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserPublicData>> GetPublicDataAsync(string userId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/public_data?");

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

    return ProcessRequestAsync<UserPublicData>(request, cancellationToken);
  }

  /// <summary>
  /// Update user public data
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the public data associated with the specified user. Only fields included in the request are updated. Public data fields can be removed by sending a `null` value for the corresponding key.
  /// </remarks>>
  /// <warning>Intended for non-sensitive attributes that may be safely exposed to client applications. When surfaced via custom claims, these values may appear in tokens issued to frontend or user-facing applications. Store only data that remains safe even if accessed through browser storage, logs, or debugging tools.</warning>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="updatePublicDataRequest">The request payload used to update a user&#39;s public data.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserPublicData</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserPublicData>> PatchPublicDataAsync(string userId, UpdatePublicDataRequest updatePublicDataRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (updatePublicDataRequest == null)
    {
      throw new ArgumentNullException(nameof(updatePublicDataRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/public_data?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(updatePublicDataRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<UserPublicData>(request, cancellationToken);
  }

  /// <summary>
  /// List blocked IP addresses
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of IP addresses currently blocked for the specified user. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of blocked IPs to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;block_until&#x60;, &#x60;last_sign_in_attempt&#x60;, &#x60;last_sign_in_success&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserIpAccessDetails&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserIpAccessDetails>, PageModel>> GetAllBlockedIpsAsync(string userId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/blocked_ips?");

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

    return ProcessRequestAsync<List<UserIpAccessDetails>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Reset IP lockout
  /// </summary>
  /// <remarks>
  /// Removes the lockout applied to the specified IP due to excessive failed authentication attempts, allowing sign-in attempts from that IP again. Providing the value `all` resets lockouts for every IP associated with the user.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user whose IP address should be unblocked.</param>
  /// <param name="unblockIpRequest">The request payload used to unblock a previously blocked IP address.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> UnblockIpAsync(string userId, UnblockIpRequest unblockIpRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (unblockIpRequest == null)
    {
      throw new ArgumentNullException(nameof(unblockIpRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/blocked_ips/unblock?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(unblockIpRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// List user sessions
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of all active sessions for the specified user. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <note>Access to user session management endpoints requires an active Pro plan subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of user sessions to return per page.</param>
  /// <param name="clientId">Filters results to user sessions associated with the specified client.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;session_id&#x60;, &#x60;initiated_at&#x60;, &#x60;expires_at&#x60;, &#x60;last_updated&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserSession&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserSession>, PageModel>> GetAllUserSessionsAsync(string userId, int? page = 1, int? size = 10, string? clientId = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/sessions?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (clientId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("clientId") + "=").Append(HttpUtility.UrlEncode(clientId)).Append("&");
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

    return ProcessRequestAsync<List<UserSession>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a user session
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information about a specific session for the specified user.
  /// </remarks>>
  /// <note>Access to user session management endpoints requires an active Pro plan subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="sessionId">The unique identifier of the user session.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserSession</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserSession>> FindUserSessionAsync(string userId, string sessionId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (sessionId == null)
    {
      throw new ArgumentNullException(nameof(sessionId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedSessionId = HttpUtility.UrlEncode(sessionId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/sessions/{encodedSessionId}?");

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

    return ProcessRequestAsync<UserSession>(request, cancellationToken);
  }

  /// <summary>
  /// Revoke a session
  /// </summary>
  /// <remarks>
  /// Revokes the specified user session, immediately terminating it and preventing further sign-in activity under that session.
  /// </remarks>>
  /// <note>Access to user session management endpoints requires an active Pro plan subscription. Existing tokens remain active unless the application enforces token-to-session binding.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="sessionId">The unique identifier of the user session.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeUserSessionAsync(string userId, string sessionId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (sessionId == null)
    {
      throw new ArgumentNullException(nameof(sessionId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedSessionId = HttpUtility.UrlEncode(sessionId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/sessions/{encodedSessionId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Disconnect an external authenticator
  /// </summary>
  /// <remarks>
  /// Removes a linked external authentication provider (such as Google, Microsoft, GitHub, etc.) from the user’s account. After disconnection, the user will no longer be able to authenticate using that provider.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="externalAuthenticatorDisconnectRequest">The request payload used to disconnect an external authenticator from a user&#39;s account.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>User</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<User>> ExternalAuthenticatorDisconnectAsync(string userId, ExternalAuthenticatorDisconnectRequest externalAuthenticatorDisconnectRequest, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (externalAuthenticatorDisconnectRequest == null)
    {
      throw new ArgumentNullException(nameof(externalAuthenticatorDisconnectRequest));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/external_authenticator/disconnect?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(externalAuthenticatorDisconnectRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<User>(request, cancellationToken);
  }

  /// <summary>
  /// List user&#39;s groups
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of user groups that the user is assigned to. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of groups to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserGroup&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserGroup>, PageModel>> GetAllUserGroupsAsync(string userId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/groups?");

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

    return ProcessRequestAsync<List<UserGroup>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a user group
  /// </summary>
  /// <remarks>
  /// Retrieves information about the specified group and the user’s membership in it.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserGroup</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserGroup>> FindUserGroupAsync(string userId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/groups/{encodedGroupId}?");

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

    return ProcessRequestAsync<UserGroup>(request, cancellationToken);
  }

  /// <summary>
  /// Assign a user to a group
  /// </summary>
  /// <remarks>
  /// Adds the specified user to the group, establishing membership and enabling access configurations assigned to that group.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>UserGroup</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<UserGroup>> AssignUserToGroupAsync(string userId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/groups/{encodedGroupId}?");

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

    return ProcessRequestAsync<UserGroup>(request, cancellationToken);
  }

  /// <summary>
  /// Remove a user from a group
  /// </summary>
  /// <remarks>
  /// Removes the specified user from the group. After removal, the user will no longer receive any access, permissions, or roles previously granted through that group.
  /// </remarks>>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveUserFromGroupAsync(string userId, Guid groupId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/groups/{encodedGroupId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List users in group
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of users assigned to the specified group. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <param name="groupId">The unique identifier of the group.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of users to return per page.</param>
  /// <param name="filter">Optional Lucene-style filter expression used to search by attributes.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;failure_count&#x60;, &#x60;last_sign_in_attempt&#x60;, &#x60;sign_in_attempts_count&#x60;, &#x60;last_sign_in_success&#x60;, &#x60;sign_in_success_count&#x60;, &#x60;last_activity&#x60;, &#x60;block_until&#x60;, &#x60;creation_time&#x60;, &#x60;last_updated&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserSummary>, PageModel>> GetAllGroupAssignedUsersAsync(Guid groupId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (groupId == Guid.Empty)
    {
      throw new ArgumentNullException(nameof(groupId));
    }

    var encodedGroupId = HttpUtility.UrlEncode(groupId.ToString());

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/groups/{encodedGroupId}/assigned?");

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

    return ProcessRequestAsync<List<UserSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List client grants
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of client-specific grants for the specified user, including consent status and counts of issued refresh tokens, reference tokens, and authorization codes.
  /// </remarks>>
  /// <note>Access to grant and token information endpoints requires an active Pro plan subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of grants to return per page.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserClientGrants&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserClientGrants>, PageModel>> GetAllUserClientGrantsAsync(string userId, int? page = 1, int? size = 10, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/clients?");

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

    return ProcessRequestAsync<List<UserClientGrants>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List user consents
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of consents granted by the specified user. Each consent includes the application's approved scopes and associated metadata. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of consent grants to return per page.</param>
  /// <param name="clientId">Filters results to consent grants issued to the specified client.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;UserConsent&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<UserConsent>, PageModel>> GetAllUserConsentsAsync(string userId, int? page = 1, int? size = 10, string? clientId = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/consents?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (clientId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("clientId") + "=").Append(HttpUtility.UrlEncode(clientId)).Append("&");
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

    return ProcessRequestAsync<List<UserConsent>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List reference tokens
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of reference tokens issued for the specified user. Reference tokens are opaque access tokens that require introspection for validation. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of grants to return per page.</param>
  /// <param name="clientId">Filters results to grants issued to the specified client.</param>
  /// <param name="sessionId">Filters results to grants issued within the specified session.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ReferenceToken&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ReferenceToken>, PageModel>> GetAllReferenceTokensAsync(string userId, int? page = 1, int? size = 10, string? clientId = default, string? sessionId = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/reference_tokens?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (clientId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("clientId") + "=").Append(HttpUtility.UrlEncode(clientId)).Append("&");
    }

    if (sessionId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sessionId") + "=").Append(HttpUtility.UrlEncode(sessionId)).Append("&");
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

    return ProcessRequestAsync<List<ReferenceToken>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List refresh tokens
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of refresh tokens issued for the specified user. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of grants to return per page.</param>
  /// <param name="clientId">Filters results to grants issued to the specified client.</param>
  /// <param name="sessionId">Filters results to grants issued within the specified session.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;RefreshToken&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<RefreshToken>, PageModel>> GetAllRefreshTokensAsync(string userId, int? page = 1, int? size = 10, string? clientId = default, string? sessionId = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/refresh_tokens?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (clientId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("clientId") + "=").Append(HttpUtility.UrlEncode(clientId)).Append("&");
    }

    if (sessionId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sessionId") + "=").Append(HttpUtility.UrlEncode(sessionId)).Append("&");
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

    return ProcessRequestAsync<List<RefreshToken>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// List authorization codes
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of authorization codes issued for the specified user. Authorization codes are ephemeral credentials used in OAuth 2.0 authorization flows before token exchange. Optional query parameters allow searching, filtering, and sorting the results.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of grants to return per page.</param>
  /// <param name="clientId">Filters results to grants issued to the specified client.</param>
  /// <param name="sessionId">Filters results to grants issued within the specified session.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60;.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;AuthorizationCode&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<AuthorizationCode>, PageModel>> GetAllAuthorizationCodesAsync(string userId, int? page = 1, int? size = 10, string? clientId = default, string? sessionId = default, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/codes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (clientId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("clientId") + "=").Append(HttpUtility.UrlEncode(clientId)).Append("&");
    }

    if (sessionId != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sessionId") + "=").Append(HttpUtility.UrlEncode(sessionId)).Append("&");
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

    return ProcessRequestAsync<List<AuthorizationCode>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Revoke client grants
  /// </summary>
  /// <remarks>
  /// Revokes all grants issued to the user for the specified application, invalidating existing authorizations.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="clientId">The unique identifier of the client.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeUserClientGrantsAsync(string userId, string clientId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke a consent
  /// </summary>
  /// <remarks>
  /// Revokes the specified consent, invalidating any previously authorized scopes. If applicable, the application must obtain new consent before acting on behalf of the user again.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="consentId">The unique identifier of the consent grant.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeUserConsentAsync(string userId, string consentId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (consentId == null)
    {
      throw new ArgumentNullException(nameof(consentId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedConsentId = HttpUtility.UrlEncode(consentId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/consents/{encodedConsentId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke a reference token
  /// </summary>
  /// <remarks>
  /// Revokes the specified reference token issued to an application, rendering it invalid for future access to protected resources.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="tokenId">The unique identifier of the reference token grant.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeReferenceTokenAsync(string userId, string tokenId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (tokenId == null)
    {
      throw new ArgumentNullException(nameof(tokenId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedTokenId = HttpUtility.UrlEncode(tokenId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/reference_tokens/{encodedTokenId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke a refresh token
  /// </summary>
  /// <remarks>
  /// Revokes the specified refresh token, rendering it unusable for obtaining new access tokens.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="tokenId">The unique identifier of the refresh token grant.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeRefreshTokenAsync(string userId, string tokenId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (tokenId == null)
    {
      throw new ArgumentNullException(nameof(tokenId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedTokenId = HttpUtility.UrlEncode(tokenId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/refresh_tokens/{encodedTokenId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Revoke an authorization code
  /// </summary>
  /// <remarks>
  /// Revokes an authorization code that has not yet been exchanged for tokens, preventing any further use.
  /// </remarks>>
  /// <note>Access to grant and token management endpoints requires an active Secure+ subscription.</note>
  /// <param name="userId">The unique identifier of the user.</param>
  /// <param name="codeId">The unique identifier of the authorization code grant.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RevokeAuthorizationCodeAsync(string userId, string codeId, CancellationToken cancellationToken = default)
  {
    if (userId == null)
    {
      throw new ArgumentNullException(nameof(userId));
    }

    if (codeId == null)
    {
      throw new ArgumentNullException(nameof(codeId));
    }

    var encodedUserId = HttpUtility.UrlEncode(userId);

    var encodedCodeId = HttpUtility.UrlEncode(codeId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"users/{encodedUserId}/grants/codes/{encodedCodeId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

