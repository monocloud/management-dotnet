namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Custom Email Branding Options Request: Used to update the content and delivery behavior of a custom email.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCustomEmailBrandingOptionsRequest>))]
public class PatchCustomEmailBrandingOptionsRequest
{
  /// <summary>
  /// Specifies whether the email notification is sent using MonoCloud-managed delivery.
  /// </summary>
  public Optional<bool> SendNotifications { get; set; }

  /// <summary>
  /// Specifies the email subject line, which may include Liquid placeholders; when empty, the default subject template is used.
  /// </summary>
  public Optional<string?> Subject { get; set; }
}


