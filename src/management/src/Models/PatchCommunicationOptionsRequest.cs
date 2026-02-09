namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Communication Options Request: Used to update email and SMS delivery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationOptionsRequest>))]
public class PatchCommunicationOptionsRequest
{
  /// <summary>
  /// Configuration options for email delivery.
  /// </summary>
  public Optional<PatchCommunicationEmailOptionsRequest> Email { get; set; }

  /// <summary>
  /// Configuration options for SMS delivery.
  /// </summary>
  public Optional<PatchCommunicationSmsOptionsRequest> Sms { get; set; }
}


