namespace MonoCloud.Management.Models;

/// <summary>
/// Log Actor Response: Represents the entity that performed the action recorded in the log entry.
/// </summary>
public class LogActor
{
  /// <summary>
  /// The actor type.
  /// </summary>
  public ActorTypes Type { get; set; }

  /// <summary>
  /// The unique identifier of the actor entity.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  /// The display name of the actor.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// The primary identifier of the actor (for example, email address).
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  /// The unique identifier of the session associated with the action.
  /// </summary>
  public string? SessionId { get; set; }
}


