namespace MonoCloud.Management.Models;

/// <summary>
/// Communication SMS Options Response: Represents SMS delivery configuration.
/// </summary>
public class CommunicationSmsOptions
{
  /// <summary>
  /// Configuration options for Twilio SMS delivery.
  /// </summary>
  public CommunicationSmsTwilioOptions? Twilio { get; set; }

  /// <summary>
  /// The SMS provider used for sending messages.
  /// </summary>
  public SmsProviders Provider { get; set; }
}


