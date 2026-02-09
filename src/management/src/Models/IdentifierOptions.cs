namespace MonoCloud.Management.Models;

/// <summary>
/// Identifier Options Response: Represents email, phone, and username identifier configuration.
/// </summary>
public class IdentifierOptions
{
  /// <summary>
  /// Email Identifier Options
  /// </summary>
  public EmailIdentifierOptions Email { get; set; }

  /// <summary>
  /// Phone Identifier Options
  /// </summary>
  public PhoneIdentifierOptions Phone { get; set; }

  /// <summary>
  /// Username Identifier Options
  /// </summary>
  public UsernameIdentifierOptions Username { get; set; }
}


