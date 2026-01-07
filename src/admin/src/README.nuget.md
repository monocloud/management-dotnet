![MonoCloud Logo](https://raw.githubusercontent.com/monocloud/management-dotnet/refs/heads/main/MonoCloud.png)

## Introduction

**MonoCloud Management Admin SDK for .NET – programmatically manage apps, policies and configurations via the MonoCloud Management APIs.**

[MonoCloud](https://www.monocloud.com?utm_source=github&utm_medium=management_dotnet) is a modern, developer-friendly Identity & Access Management platform.

This SDK provides a full-featured, typed .NET client for interacting with the **MonoCloud Management APIs**, allowing you to automate tenant administration programmatically.

## 📘 Documentation

- **Documentation:** [https://www.monocloud.com/docs](https://www.monocloud.com/docs?utm_source=github&utm_medium=management_dotnet)
- **SDK Docs:** [https://www.monocloud.com/docs/apis/management](https://www.monocloud.com/docs/apis/management?utm_source=github&utm_medium=management_dotnet)
- **API Reference:** [https://monocloud.github.io/management-dotnet](https://monocloud.github.io/management-dotnet?utm_source=github&utm_medium=management_dotnet)

## Supported Platforms

This SDK supports applications targeting:

- **.NET Standard 2.0** (recommended for maximum compatibility)
- **.NET Framework 4.6.1+**
- **.NET 6.0+** and later

## 🚀 Getting Started

### Requirements

- A **MonoCloud tenant**
- A **Management API key** with appropriate permissions

## Admin API

### 📦 Installation

```powershell
Install-Package MonoCloud.Management.Admin

# or

dotnet add package MonoCloud.Management.Admin
```

### Usage

```csharp
var adminClient = new MonoCloudAdminClient(new MonoCloudConfig("https://<your-tenant-domain>", "<your-api-key>"));
```

⚠️ **Security Note:** Do not hardcode your API key. It is recommended to load it from an environment variable or a secure configuration manager like appsettings.json. For modern .NET applications, it is best practice to use Dependency Injection to manage the client lifecycle and configuration securely via the [`AddMonoCloudAdminClient`](https://github.com/monocloud/management-dotnet/blob/main/src/admin/src/MonoCloudAdminServiceExtensions.cs) service extension.

### ✨ Usage Examples

The SDK closely mirrors the REST API structure — clients are organized by resource areas (clients, resources, etc.).

#### 🔍 Get all clients

```csharp
var result = await adminClient.Clients.GetAllClientsAsync(
    page: 1,
    size: 10,
    filter: "dashboard",
    sort: "name:1"
);
```

Explore further operations (clients, options, trust stores, etc.) using the same patterns.
See: [https://www.monocloud.com/docs](https://www.monocloud.com/docs?utm_source=github&utm_medium=management_dotnet)

## 🤝 Contributing & Support

### Issues & Feedback

- Use **GitHub Issues** for bug reports and feature requests.
- For tenant or account-specific help, contact MonoCloud Support through your dashboard.

### Security

Do **not** report security issues publicly. Please follow the contact instructions at: [https://www.monocloud.com/contact](https://www.monocloud.com/contact?utm_source=github&utm_medium=management_dotnet)

## 📄 License

Licensed under the **MIT License**. See the included [`LICENSE`](https://github.com/monocloud/management-dotnet/blob/main/LICENSE) file.
