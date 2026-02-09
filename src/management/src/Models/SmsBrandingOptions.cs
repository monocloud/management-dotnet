namespace MonoCloud.Management.Models;

/// <summary>
/// SMS Branding Options Response: Represents the SMS branding configuration applied to system-generated messages.
/// </summary>
public class SmsBrandingOptions
{
  /// <summary>
  /// Configuration for sign-in SMS messages, including delivery enablement and message template.
  /// </summary>
  public CustomSmsBrandingOptions SignIn { get; set; }

  /// <summary>
  /// Configuration for verification SMS messages, including delivery enablement and message template.
  /// </summary>
  public CustomSmsBrandingOptions Verification { get; set; }

  /// <summary>
  /// Configuration for password reset SMS messages, including delivery enablement and message template.
  /// </summary>
  public CustomSmsBrandingOptions PasswordReset { get; set; }
}


