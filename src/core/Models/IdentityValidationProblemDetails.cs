namespace MonoCloud.Management.Core.Models;

public class IdentityValidationProblemDetails : ProblemDetails
{
  /// <summary>
  /// A collection of error codes
  /// </summary>
  public IEnumerable<IdentityError> Errors { get; set; } = new List<IdentityError>();
}
