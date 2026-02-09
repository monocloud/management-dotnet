namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Page Branding Options Request: Used to update the visual appearance and localization of hosted authentication pages.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPageBrandingOptionsRequest>))]
public class PatchPageBrandingOptionsRequest
{
  /// <summary>
  /// Specifies whether the MonoCloud watermark is displayed on hosted login pages.
  /// </summary>
  public Optional<bool> ShowWatermark { get; set; }

  /// <summary>
  /// Defines the primary brand color used across hosted login pages (HEX format).
  /// </summary>
  public Optional<string> PrimaryColor { get; set; }

  /// <summary>
  /// Defines the background color of hosted login pages (HEX format).
  /// </summary>
  public Optional<string> BackgroundColor { get; set; }
}


