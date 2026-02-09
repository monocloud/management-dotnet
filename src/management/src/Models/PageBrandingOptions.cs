namespace MonoCloud.Management.Models;

/// <summary>
/// Page Branding Options Response: Represents visual and layout branding settings applied to hosted pages.
/// </summary>
public class PageBrandingOptions
{
  /// <summary>
  /// Specifies whether the MonoCloud watermark is displayed on hosted login pages.
  /// </summary>
  public bool ShowWatermark { get; set; }

  /// <summary>
  /// Defines the primary brand color used across hosted login pages (HEX format).
  /// </summary>
  public string PrimaryColor { get; set; }

  /// <summary>
  /// Defines the background color of hosted login pages (HEX format).
  /// </summary>
  public string BackgroundColor { get; set; }
}


