namespace MonoCloud.Management.Models;

/// <summary>
/// Username Identifier Options Response: Represents username sign-in and sign-up configuration.
/// </summary>
public class UsernameIdentifierOptions
{
  /// <summary>
  /// Specifies whether users can sign in using a username.
  /// </summary>
  public bool EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether a username can be collected during sign-up.
  /// </summary>
  public bool ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether a username is required during sign-up.
  /// </summary>
  public bool RequiredAtSignUp { get; set; }

  /// <summary>
  /// Specifies the minimum length required for the username.
  /// </summary>
  public int MinimumLength { get; set; }
}


