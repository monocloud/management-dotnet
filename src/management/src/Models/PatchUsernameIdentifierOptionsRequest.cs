namespace MonoCloud.Management.Models;

/// <summary>
/// Patch Username Identifier Options Request: Used to update username sign-in and sign-up settings.
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchUsernameIdentifierOptionsRequest>))]
public class PatchUsernameIdentifierOptionsRequest
{
  /// <summary>
  /// Specifies whether users can sign in using a username.
  /// </summary>
  public Optional<bool> EnableSignIn { get; set; }

  /// <summary>
  /// Specifies whether a username can be collected during sign-up.
  /// </summary>
  public Optional<bool> ShowAtSignUp { get; set; }

  /// <summary>
  /// Specifies whether a username is required during sign-up.
  /// </summary>
  public Optional<bool> RequiredAtSignUp { get; set; }

  /// <summary>
  /// Specifies the minimum length required for the username.
  /// </summary>
  public Optional<int> MinimumLength { get; set; }
}


