namespace MonoCloud.Management.Models;

/// <summary>
/// Log Target Response: Represents the entity affected by the log event.
/// </summary>
public class LogTarget
{
  /// <summary>
  /// The target type.
  /// </summary>
  public TargetTypes Type { get; set; }

  /// <summary>
  /// The unique identifier of the target entity.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  /// The display name of the target entity.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// The primary identifier of the target entity (for example, email address).
  /// </summary>
  public string? Identifier { get; set; }
}


