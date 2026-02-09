namespace MonoCloud.Management.Models;

/// <summary>
/// Verify Email Response: Returns the delivery status of the verification email.
/// </summary>
public class VerifyEmailResponse
{
  /// <summary>
  /// The expiry time for the verification link (in Epoch).
  /// </summary>
  public DateTime ExpiresAt { get; set; }

  /// <summary>
  /// Specifies whether the verification email was sent to the user.
  /// </summary>
  public bool EmailSent { get; set; }
}


