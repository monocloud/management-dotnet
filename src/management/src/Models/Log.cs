namespace MonoCloud.Management.Models;

/// <summary>
/// Log Response: Represents an audit log entry capturing a system or security event.
/// </summary>
public class Log
{
  /// <summary>
  /// The unique identifier of the log entry.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Specifies the event time (in Epoch).
  /// </summary>
  public DateTime TimeStamp { get; set; }

  /// <summary>
  /// The event category.
  /// </summary>
  public LogCategories Category { get; set; }

  /// <summary>
  /// The event name.
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// A human-readable description of the event.
  /// </summary>
  public string Description { get; set; }

  /// <summary>
  /// The event severity/type.
  /// </summary>
  public EventTypes Type { get; set; }

  /// <summary>
  /// The event code.
  /// </summary>
  public EventCodes Code { get; set; }

  /// <summary>
  /// The message associated with the event.
  /// </summary>
  public string? Message { get; set; }

  /// <summary>
  /// System/environment details for the event.
  /// </summary>
  public LogSystem System { get; set; }

  /// <summary>
  /// Request details for the event.
  /// </summary>
  public LogRequest Request { get; set; }

  /// <summary>
  /// The source endpoint or path that generated the event.
  /// </summary>
  public string? Source { get; set; }

  /// <summary>
  /// The actor that performed the action.
  /// </summary>
  public LogActor Actor { get; set; }

  /// <summary>
  /// The targets affected by the action.
  /// </summary>
  public List<LogTarget> Targets { get; set; }

  /// <summary>
  /// The client application details.
  /// </summary>
  public LogClient? Client { get; set; }

  /// <summary>
  /// Log Details Response: Represents additional event-specific details associated with the log entry.
  /// </summary>
  public object Details { get; set; }
}


