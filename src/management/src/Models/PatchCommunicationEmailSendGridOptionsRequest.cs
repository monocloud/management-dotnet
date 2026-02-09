namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Communication Email SendGrid Options Request: Used to update SendGrid-specific email delivery configuration.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationEmailSendGridOptionsRequest>))]
public class PatchCommunicationEmailSendGridOptionsRequest
{
  /// <summary>
  /// SendGrid API key used to authenticate requests to the SendGrid service.
  /// </summary>
  public Optional<string> ApiKey { get; set; }

  /// <summary>
  /// The email address used as the sender for outgoing emails.
  /// </summary>
  public Optional<string> FromEmail { get; set; }

  /// <summary>
  /// The display name used as the sender for outgoing emails.
  /// </summary>
  public Optional<string?> FromName { get; set; }
}


