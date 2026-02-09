namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Email Branding Options Request: Used to update email branding configuration for system-generated emails.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchEmailBrandingOptionsRequest>))]
public class PatchEmailBrandingOptionsRequest
{
  /// <summary>
  /// Configuration for welcome emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> Welcome { get; set; }

  /// <summary>
  /// Configuration for user blocked notification emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> UserBlocked { get; set; }

  /// <summary>
  /// Configuration for sign-in code emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> SignInCode { get; set; }

  /// <summary>
  /// Configuration for sign-in link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> SignInLink { get; set; }

  /// <summary>
  /// Configuration for sign-in code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> SignInCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for verification code emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> VerificationCode { get; set; }

  /// <summary>
  /// Configuration for verification link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> VerificationLink { get; set; }

  /// <summary>
  /// Configuration for verification code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> VerificationCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for password reset code emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> PasswordResetCode { get; set; }

  /// <summary>
  /// Configuration for password reset link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> PasswordResetLink { get; set; }

  /// <summary>
  /// Configuration for password reset code and link emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> PasswordResetCodeAndLink { get; set; }

  /// <summary>
  /// Configuration for password updated notification emails, including delivery enablement, subject, and template.
  /// </summary>
  public Optional<PatchCustomEmailBrandingOptionsRequest> PasswordUpdated { get; set; }
}


