namespace MonoCloud.Management.Models;

/// <summary>
/// The log event type.
/// </summary>
public enum EventTypes
{
  /// <summary>
  /// Indicates that the operation completed successfully.
  /// </summary>
  Success,

  /// <summary>
  /// Indicates that the operation failed to complete as expected.
  /// </summary>
  Failure,

  /// <summary>
  /// Indicates an informational event that does not represent an error or failure.
  /// </summary>
  Information,

  /// <summary>
  /// Indicates an error condition encountered during processing.
  /// </summary>
  Error
}


