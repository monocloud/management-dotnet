namespace MonoCloud.Management.Models;

/// <summary>
/// Custom Email Branding Options Response: Represents branding configuration for a specific system-generated email message.
/// </summary>
public class CustomEmailBrandingOptions
{
  /// <summary>
  /// Specifies whether the email notification is sent using MonoCloud-managed delivery.
  /// </summary>
  public bool SendNotifications { get; set; }

  /// <summary>
  /// Specifies the email subject line, which may include Liquid placeholders; when empty, the default subject template is used.
  /// </summary>
  public string? Subject { get; set; }
}


