namespace MonoCloud.Management.Models;

/// <summary>
/// Communication Email SendGrid Options Response: Represents SendGrid-specific email delivery configuration.
/// </summary>
public class CommunicationEmailSendGridOptions
{
  /// <summary>
  /// SendGrid API key used to authenticate requests to the SendGrid service.
  /// </summary>
  public string ApiKey { get; set; }

  /// <summary>
  /// The email address used as the sender for outgoing emails.
  /// </summary>
  public string FromEmail { get; set; }

  /// <summary>
  /// The display name used as the sender for outgoing emails.
  /// </summary>
  public string? FromName { get; set; }
}


