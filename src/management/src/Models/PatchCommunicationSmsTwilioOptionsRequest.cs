namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Communication SMS Twilio Options Request: Used to update Twilio-specific SMS delivery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationSmsTwilioOptionsRequest>))]
public class PatchCommunicationSmsTwilioOptionsRequest
{
  /// <summary>
  /// The Twilio Account SID.
  /// </summary>
  public Optional<string> Sid { get; set; }

  /// <summary>
  /// The Twilio Auth Token associated with the account.
  /// </summary>
  public Optional<string> AuthToken { get; set; }

  /// <summary>
  /// The Twilio Messaging Service SID used to send SMS messages.
  /// </summary>
  public Optional<string?> MessagingSid { get; set; }

  /// <summary>
  /// The sender phone number or alphanumeric sender ID used for SMS messages.
  /// </summary>
  public Optional<string?> From { get; set; }
}


