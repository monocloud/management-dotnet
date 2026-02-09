namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Communication Email Options Request: Used to update the email delivery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationEmailOptionsRequest>))]
public class PatchCommunicationEmailOptionsRequest
{
  /// <summary>
  /// The email provider used for sending messages.
  /// </summary>
  public Optional<EmailProviders> Provider { get; set; }

  /// <summary>
  /// Configuration options for SendGrid email delivery.
  /// </summary>
  public Optional<PatchCommunicationEmailSendGridOptionsRequest?> SendGrid { get; set; }
}


