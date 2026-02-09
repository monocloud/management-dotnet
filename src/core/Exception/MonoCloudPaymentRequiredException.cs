namespace MonoCloud.Management.Core.Exception;

/// <summary>
/// The MonoCloud Payment Required Exception
/// </summary>
public class MonoCloudPaymentRequiredException : MonoCloudRequestException
{
  /// <summary>
  /// Initializes the MonoCloudPaymentRequiredException Class
  /// </summary>
  /// <param name="response">The problem details returned from the server.</param>
  public MonoCloudPaymentRequiredException(ProblemDetails response) : base(response)
  {
  }

  /// <summary>
  /// Initializes the MonoCloudPaymentRequiredException Class
  /// </summary>
  /// <param name="message">The error message returned from the server.</param>
  public MonoCloudPaymentRequiredException(string message) : base(message)
  {
  }
}
