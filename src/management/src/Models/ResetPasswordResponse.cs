namespace MonoCloud.Management.Models;

/// <summary>
/// Reset Password Response: Returns the delivery status of the password reset email.
/// </summary>
public class ResetPasswordResponse
{
  /// <summary>
  /// The generated password reset link that can be used to complete the reset flow.
  /// </summary>
  public string Link { get; set; }

  /// <summary>
  /// Specifies the expiry time for the password reset link (in Epoch).
  /// </summary>
  public DateTime ExpiresAt { get; set; }

  /// <summary>
  /// Indicates whether the password reset email was sent to the user.
  /// </summary>
  public bool EmailSent { get; set; }
}


