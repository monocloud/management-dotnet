namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Identity Validation Exception
/// </summary>
public class MonoCloudIdentityValidationException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudIdentityValidationException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudIdentityValidationException(IdentityValidationProblemDetails response) : base(response, response.Title + ": " + JsonSerializer.Serialize(response.Errors, new JsonSerializerOptions { WriteIndented = true }))
  {
    Errors = response.Errors;
  }

  /// <summary>
  /// A list of errors corresponding to the model properties, if any.
  /// </summary>
  public IEnumerable<IdentityError> Errors { get; set; }
}
