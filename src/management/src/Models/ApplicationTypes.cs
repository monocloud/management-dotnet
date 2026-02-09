namespace MonoCloud.Management.Models;

/// <summary>
/// The application type.
/// </summary>
public enum ApplicationTypes
{
  /// <summary>
  /// General-purpose or custom application type
  /// </summary>
  Custom,

  /// <summary>
  /// Single Page Application (browser-based, running entirely in the user’s browser)
  /// </summary>
  Spa,

  /// <summary>
  /// Traditional web application with a backend server
  /// </summary>
  WebApp,

  /// <summary>
  /// Native desktop or mobile application
  /// </summary>
  Native,

  /// <summary>
  /// Machine-to-machine or backend service
  /// </summary>
  M2m,

  /// <summary>
  /// Device or console that authenticates using the device authorization flow
  /// </summary>
  Device
}


