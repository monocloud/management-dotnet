namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Custom SMS Branding Options Request: Used to update a custom SMS template.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCustomSmsBrandingOptionsRequest>))]
public class PatchCustomSmsBrandingOptionsRequest
{
  /// <summary>
  /// Custom Liquid template used to render the SMS message content with runtime variables; when empty, the default template is used.
  /// </summary>
  public Optional<string?> Template { get; set; }
}


