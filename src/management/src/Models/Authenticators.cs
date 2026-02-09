namespace MonoCloud.Management.Models;

/// <summary>
/// The authenticator.
/// </summary>
public enum Authenticators
{
  /// <summary>
  /// Username / password based authentication
  /// </summary>
  Password,

  /// <summary>
  /// Passkey (FIDO2 / WebAuthn) based authentication
  /// </summary>
  Passkey,

  /// <summary>
  /// Email-based authentication (magic links or OTP)
  /// </summary>
  Email,

  /// <summary>
  /// Phone-based authentication using SMS OTP
  /// </summary>
  Phone,

  /// <summary>
  /// Sign in with Google
  /// </summary>
  Google,

  /// <summary>
  /// Sign in with Apple
  /// </summary>
  Apple,

  /// <summary>
  /// Sign in with Facebook
  /// </summary>
  Facebook,

  /// <summary>
  /// Sign in with Microsoft
  /// </summary>
  Microsoft,

  /// <summary>
  /// Sign in with GitHub
  /// </summary>
  Github,

  /// <summary>
  /// Sign in with GitLab
  /// </summary>
  Gitlab,

  /// <summary>
  /// Sign in with Discord
  /// </summary>
  Discord,

  /// <summary>
  /// Sign in with Twitter
  /// </summary>
  Twitter,

  /// <summary>
  /// Sign in with LinkedIn
  /// </summary>
  Linkedin,

  /// <summary>
  /// Sign in with Xero
  /// </summary>
  Xero
}


