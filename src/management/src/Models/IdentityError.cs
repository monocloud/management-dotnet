namespace MonoCloud.Management.Models;

/// <summary>
/// Identity Error: Represents a validation or processing error returned by the identity system.
/// </summary>
public class IdentityError
{
  /// <summary>
  /// Machine-readable error code.
  /// </summary>
  public string Code { get; set; }

  /// <summary>
  /// Human-readable description of the error.
  /// </summary>
  public string Description { get; set; }
}


