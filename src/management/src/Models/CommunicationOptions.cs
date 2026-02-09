namespace MonoCloud.Management.Models;

/// <summary>
/// Communication Options Response: Represents the current email and SMS delivery configuration.
/// </summary>
public class CommunicationOptions
{
  /// <summary>
  /// Configuration options for email delivery.
  /// </summary>
  public CommunicationEmailOptions Email { get; set; }

  /// <summary>
  /// Configuration options for SMS delivery.
  /// </summary>
  public CommunicationSmsOptions Sms { get; set; }
}


