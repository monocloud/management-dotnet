namespace MonoCloud.Management.Models;

/// <summary>
/// Recovery Methods Options Response: Represents the configuration for account and password recovery.
/// </summary>
public class RecoveryMethodsOptions
{
  /// <summary>
  /// Recovery Methods Email Options
  /// </summary>
  public RecoveryMethodsEmailOptions Email { get; set; }

  /// <summary>
  /// Recovery Methods Phone Options
  /// </summary>
  public RecoveryMethodsPhoneOptions Phone { get; set; }
}


