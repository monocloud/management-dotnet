namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Key Validation Exception Exception
/// </summary>
public class MonoCloudKeyValidationException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudKeyValidationException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudKeyValidationException(KeyValidationProblemDetails response) : base(response, response.Title + ": " + JsonSerializer.Serialize(response.Errors, new JsonSerializerOptions { WriteIndented = true }))
  {
    Errors = response.Errors;
  }

  /// <summary>
  /// A list of errors corresponding to the model properties, if any.
  /// </summary>
  public IDictionary<string, string[]> Errors { get; set; }
}
