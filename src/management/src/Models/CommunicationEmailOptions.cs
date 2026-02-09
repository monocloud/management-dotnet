namespace MonoCloud.Management.Models;

/// <summary>
/// Communication Email Options Response: Represents the email delivery configuration.
/// </summary>
public class CommunicationEmailOptions
{
  /// <summary>
  /// Configuration options for SendGrid email delivery.
  /// </summary>
  public CommunicationEmailSendGridOptions? SendGrid { get; set; }

  /// <summary>
  /// The email provider used for sending messages.
  /// </summary>
  public EmailProviders Provider { get; set; }

  /// <summary>
  /// The tenant-specific sender email address.
  /// </summary>
  public string DefaultFromEmail { get; set; }
}


