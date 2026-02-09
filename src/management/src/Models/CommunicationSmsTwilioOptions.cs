namespace MonoCloud.Management.Models;

/// <summary>
/// Communication SMS Twilio Options Response: Represents Twilio-specific SMS delivery configuration.
/// </summary>
public class CommunicationSmsTwilioOptions
{
  /// <summary>
  /// The Twilio Account SID.
  /// </summary>
  public string Sid { get; set; }

  /// <summary>
  /// The Twilio Auth Token associated with the account.
  /// </summary>
  public string AuthToken { get; set; }

  /// <summary>
  /// The Twilio Messaging Service SID used to send SMS messages.
  /// </summary>
  public string? MessagingSid { get; set; }

  /// <summary>
  /// The sender phone number or alphanumeric sender ID used for SMS messages.
  /// </summary>
  public string? From { get; set; }
}


