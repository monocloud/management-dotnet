namespace MonoCloud.Management.Models;

/// <summary>
/// Custom SMS Branding Options Response: Represents branding configuration for a specific system-generated SMS.
/// </summary>
public class CustomSmsBrandingOptions
{
  /// <summary>
  /// Custom Liquid template used to render the SMS message content with runtime variables; when empty, the default template is used.
  /// </summary>
  public string? Template { get; set; }
}


