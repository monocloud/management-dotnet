namespace MonoCloud.Management.Models;

/// <summary>
/// The remember consent type.
/// </summary>
public enum RememberConsentTypes
{
  /// <summary>
  /// Consent is never remembered. Users are prompted every time.
  /// </summary>
  Never,

  /// <summary>
  /// Consent is always remembered automatically and never prompted again.
  /// </summary>
  Always,

  /// <summary>
  /// Users may choose whether their consent decision should be remembered.
  /// </summary>
  UserSelected
}


