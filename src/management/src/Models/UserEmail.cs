namespace MonoCloud.Management.Models;

/// <summary>
/// User Email: Represents an email address associated with the user account.
/// </summary>
public class UserEmail
{
  /// <summary>
  /// Unique identifier of the user&#39;s email.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Indicates whether this is the primary email address for the user.
  /// </summary>
  public bool Primary { get; set; }

  /// <summary>
  /// Indicates whether the email address has been verified.
  /// </summary>
  public bool Verified { get; set; }

  /// <summary>
  /// Source from which the email address was originally collected.
  /// </summary>
  public string? Source { get; set; }

  /// <summary>
  /// Identity provider or service that verified the email address.
  /// </summary>
  public string? VerificationSource { get; set; }

  /// <summary>
  /// The email address.
  /// </summary>
  public string Email { get; set; }
}


