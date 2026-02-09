namespace MonoCloud.Management;

/// <summary>
/// The MonoCloud Management Client Class
/// </summary>
public class MonoCloudManagementClient
{
  /// <summary>
  /// Gets the BrandingClient instance to interact with the Branding Api endpoints
  /// </summary>
  public BrandingClient Branding { get; }

  /// <summary>
  /// Gets the ClientsClient instance to interact with the Clients Api endpoints
  /// </summary>
  public ClientsClient Clients { get; }

  /// <summary>
  /// Gets the GroupsClient instance to interact with the Groups Api endpoints
  /// </summary>
  public GroupsClient Groups { get; }

  /// <summary>
  /// Gets the KeysClient instance to interact with the Keys Api endpoints
  /// </summary>
  public KeysClient Keys { get; }

  /// <summary>
  /// Gets the LogsClient instance to interact with the Logs Api endpoints
  /// </summary>
  public LogsClient Logs { get; }

  /// <summary>
  /// Gets the OptionsClient instance to interact with the Options Api endpoints
  /// </summary>
  public OptionsClient Options { get; }

  /// <summary>
  /// Gets the ResourcesClient instance to interact with the Resources Api endpoints
  /// </summary>
  public ResourcesClient Resources { get; }

  /// <summary>
  /// Gets the TrustStoresClient instance to interact with the TrustStores Api endpoints
  /// </summary>
  public TrustStoresClient TrustStores { get; }

  /// <summary>
  /// Gets the UsersClient instance to interact with the Users Api endpoints
  /// </summary>
  public UsersClient Users { get; }

  /// <summary>
  /// Initializes the MonoCloud Management Client Class
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  public MonoCloudManagementClient(MonoCloudConfig configuration)
  {
    Branding = new BrandingClient(configuration);
    Clients = new ClientsClient(configuration);
    Groups = new GroupsClient(configuration);
    Keys = new KeysClient(configuration);
    Logs = new LogsClient(configuration);
    Options = new OptionsClient(configuration);
    Resources = new ResourcesClient(configuration);
    TrustStores = new TrustStoresClient(configuration);
    Users = new UsersClient(configuration);
  }


  /// <summary>
  /// Initializes the MonoCloud Management Client Class
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  public MonoCloudManagementClient(HttpClient httpClient)
  {
    Branding = new BrandingClient(httpClient);
    Clients = new ClientsClient(httpClient);
    Groups = new GroupsClient(httpClient);
    Keys = new KeysClient(httpClient);
    Logs = new LogsClient(httpClient);
    Options = new OptionsClient(httpClient);
    Resources = new ResourcesClient(httpClient);
    TrustStores = new TrustStoresClient(httpClient);
    Users = new UsersClient(httpClient);
  }
}
