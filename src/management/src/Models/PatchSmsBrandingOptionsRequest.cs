namespace MonoCloud.Management.Models;

/// <summary>
/// Patch SMS Branding Options Request: Used to update SMS templates for system-generated messages.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchSmsBrandingOptionsRequest>))]
public class PatchSmsBrandingOptionsRequest
{
  /// <summary>
  /// Configuration for sign-in SMS messages, including delivery enablement and message template.
  /// </summary>
  public Optional<PatchCustomSmsBrandingOptionsRequest> SignIn { get; set; }

  /// <summary>
  /// Configuration for verification SMS messages, including delivery enablement and message template.
  /// </summary>
  public Optional<PatchCustomSmsBrandingOptionsRequest> Verification { get; set; }

  /// <summary>
  /// Configuration for password reset SMS messages, including delivery enablement and message template.
  /// </summary>
  public Optional<PatchCustomSmsBrandingOptionsRequest> PasswordReset { get; set; }
}


