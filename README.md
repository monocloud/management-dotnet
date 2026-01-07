<div align="center">
  <a href="https://www.monocloud.com?utm_source=github&utm_medium=management_dotnet" target="_blank" rel="noopener noreferrer">
    <picture>
      <img src="https://raw.githubusercontent.com/monocloud/management-dotnet/refs/heads/main/MonoCloud.png" height="100" alt="MonoCloud Logo">
    </picture>
  </a>
  <p>Secure, simple auth for everything</p>
  <img src="https://img.shields.io/nuget/v/MonoCloud.Management.Core" alt="NuGet" />
  <a href="https://opensource.org/licenses/MIT">
    <img src="https://img.shields.io/:license-MIT-blue.svg?style=flat" alt="License: MIT" />
  </a>
  <a href="https://github.com/monocloud/management-dotnet/actions/workflows/build.yaml">
    <img src="https://github.com/monocloud/management-dotnet/actions/workflows/build.yaml/badge.svg" alt="Build Status" />
  </a>
</div>

<br /><br />

## Introduction

**MonoCloud Management SDK for .NET – programmatically manage apps, policies, configurations, and users via the MonoCloud Management APIs.**

[MonoCloud](https://www.monocloud.com?utm_source=github&utm_medium=management_dotnet) is a modern, developer-friendly Identity & Access Management platform.

This SDK provides a full-featured, typed .NET client for interacting with the **MonoCloud Management APIs**, allowing you to automate tenant administration programmatically.

## 📘 Documentation

- **Documentation:** [https://www.monocloud.com/docs](https://www.monocloud.com/docs?utm_source=github&utm_medium=management_dotnet)
- **Management API SDK Docs:** [https://www.monocloud.com/docs/apis/management](https://www.monocloud.com/docs/apis/management?utm_source=github&utm_medium=management_dotnet)
- **Identity API SDK Docs:** [https://www.monocloud.com/docs/apis/identity](https://www.monocloud.com/docs/apis/identity?utm_source=github&utm_medium=management_dotnet)
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

## Identity API

### 📦 Installation

```powershell
Install-Package MonoCloud.Management.Identity

# or

dotnet add package MonoCloud.Management.Identity
```

### Usage

```csharp
var identityClient = new MonoCloudIdentityClient(new MonoCloudConfig("https://<your-tenant-domain>", "<your-api-key>"));
```

⚠️ **Security Note:** Do not hardcode your API key. It is recommended to load it from an environment variable or a secure configuration manager like appsettings.json. For modern .NET applications, it is best practice to use Dependency Injection to manage the client lifecycle and configuration securely via the [`AddMonoCloudIdentityClient`](https://github.com/monocloud/management-dotnet/blob/main/src/identity/src/MonoCloudIdentityServiceExtensions.cs) service extension.

### ✨ Usage Examples

The SDK closely mirrors the REST API structure — clients are organized by users and groups.

#### 🔍 Get all users

```csharp
var result = await identityClient.Users.GetAllUsersAsync(
    page: 1,
    size: 10,
    filter: "bob",
    sort: "given_name:1"
);
```

Explore further operations at [https://www.monocloud.com/docs](https://www.monocloud.com/docs?utm_source=github&utm_medium=management_dotnet)

## 🤝 Contributing & Support

### Issues & Feedback

- Use **GitHub Issues** for bug reports and feature requests.
- For tenant or account-specific help, contact MonoCloud Support through your dashboard.

### Security

Do **not** report security issues publicly. Please follow the contact instructions at: [https://www.monocloud.com/contact](https://www.monocloud.com/contact?utm_source=github&utm_medium=management_dotnet)

## 📄 License

Licensed under the **MIT License**. See the included [`LICENSE`](https://github.com/monocloud/management-dotnet/blob/main/LICENSE) file.
