namespace MonoCloud.Management.Models;

/// <summary>
/// Email Branding Options Response: Represents the email branding configuration applied to system-generated emails.
/// </summary>
public class EmailBrandingOptions
{
  /// <summary>
  /// Configuration for welcome emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions Welcome { get; set; }

  /// <summary>
  /// Configuration for user blocked notification emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions UserBlocked { get; set; }

  /// <summary>
  /// Configuration for sign-in code emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions SignInCode { get; set; }

  /// <summary>
  /// Configuration for sign-in link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions SignInLink { get; set; }

  /// <summary>
  /// Configuration for sign-in code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions SignInCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for verification code emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions VerificationCode { get; set; }

  /// <summary>
  /// Configuration for verification link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions VerificationLink { get; set; }

  /// <summary>
  /// Configuration for verification code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions VerificationCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for password reset code emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions PasswordResetCode { get; set; }

  /// <summary>
  /// Configuration for password reset link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions PasswordResetLink { get; set; }

  /// <summary>
  /// Configuration for password reset code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions PasswordResetCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for password updated notification emails, including delivery enablement, subject, and template.
  /// </summary>
  public CustomEmailBrandingOptions PasswordUpdated { get; set; }
}


