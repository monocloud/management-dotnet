namespace MonoCloud.Management.Models;

/// <summary>
/// User Phone: Represents a phone number associated with the user account.
/// </summary>
public class UserPhone
{
  /// <summary>
  /// Unique identifier of the user&#39;s phone.
  /// </summary>
  public Guid Id { get; set; }

  /// <summary>
  /// Indicates whether this is the primary phone number for the user.
  /// </summary>
  public bool Primary { get; set; }

  /// <summary>
  /// Indicates whether the phone number has been verified.
  /// </summary>
  public bool Verified { get; set; }

  /// <summary>
  /// Source from which the phone number was originally collected.
  /// </summary>
  public string? Source { get; set; }

  /// <summary>
  /// Identity provider or service that verified the phone number.
  /// </summary>
  public string? VerificationSource { get; set; }

  /// <summary>
  /// The phone number.
  /// </summary>
  public string Phone { get; set; }
}


