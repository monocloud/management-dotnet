namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Communication SMS Options Request: Used to update the SMS delivery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationSmsOptionsRequest>))]
public class PatchCommunicationSmsOptionsRequest
{
  /// <summary>
  /// The SMS provider used for sending messages.
  /// </summary>
  public Optional<SmsProviders> Provider { get; set; }

  /// <summary>
  /// Configuration options for Twilio SMS delivery.
  /// </summary>
  public Optional<PatchCommunicationSmsTwilioOptionsRequest?> Twilio { get; set; }
}


