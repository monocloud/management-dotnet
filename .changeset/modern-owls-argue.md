---
"@monocloud/management-dotnet": patch
---

Refactor identity validation and exception types

- Removed the `field` property from the validation problem-details type (cleaned up field-level validation payload).
- Renamed `ErrorCodeValidationError` → `IdentityError` for clearer intent.
- Renamed `ErrorCodeValidationProblemDetails` → `IdentityValidationProblemDetails`.
- Renamed `MonoCloudErrorCodeValidationException` → `MonoCloudIdentityValidationException`.
- Updated package consumers in `MonoCloud.Management.Identity`, `MonoCloud.Management.Admin`, and `MonoCloud.Management.Core` to use the new names and shapes.
