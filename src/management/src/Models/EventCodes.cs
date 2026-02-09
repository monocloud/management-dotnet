namespace MonoCloud.Management.Models;

/// <summary>
/// The log event code.
/// </summary>
public enum EventCodes
{
  /// <summary>
  /// Indicates a successful authorization request.
  /// </summary>
  AuthorizationSucceeded,

  /// <summary>
  /// Indicates a failed authorization request (e.g., invalid request, denied by policy).
  /// </summary>
  AuthorizationFailed,

  /// <summary>
  /// Indicates a successful Pushed Authorization Request (PAR).
  /// </summary>
  PushedAuthorizationSucceeded,

  /// <summary>
  /// Indicates a failed Pushed Authorization Request (PAR).
  /// </summary>
  PushedAuthorizationFailed,

  /// <summary>
  /// Indicates a successful OAuth client authentication.
  /// </summary>
  ClientAuthenticationSucceeded,

  /// <summary>
  /// Indicates a failed OAuth client authentication (e.g., invalid client credentials).
  /// </summary>
  ClientAuthenticationFailed,

  /// <summary>
  /// Indicates a successful API authentication.
  /// </summary>
  ApiAuthenticationSucceeded,

  /// <summary>
  /// Indicates a failed API authentication (e.g., invalid or missing access token).
  /// </summary>
  ApiAuthenticationFailed,

  /// <summary>
  /// Indicates a successful Resource Owner Password Credentials (ROPC) authentication flow.
  /// </summary>
  PasswordFlowAuthenticationSucceeded,

  /// <summary>
  /// Indicates a failed Resource Owner Password Credentials (ROPC) authentication flow.
  /// </summary>
  PasswordFlowAuthenticationFailed,

  /// <summary>
  /// Indicates a successful device authorization flow.
  /// </summary>
  DeviceAuthorizationSucceeded,

  /// <summary>
  /// Indicates a failed device authorization flow.
  /// </summary>
  DeviceAuthorizationFailed,

  /// <summary>
  /// Indicates a successful client certificate (mTLS) authentication.
  /// </summary>
  MtlsAuthenticationSucceeded,

  /// <summary>
  /// Indicates a failed client certificate (mTLS) authentication.
  /// </summary>
  MtlsAuthenticationFailed,

  /// <summary>
  /// Indicates a failed identifier-based sign-in attempt (e.g., username or email lookup).
  /// </summary>
  UserLookupFailed,

  /// <summary>
  /// Indicates a failed external identity provider sign-in.
  /// </summary>
  ExternalProviderAuthenticationFailed,

  /// <summary>
  /// Indicates a successful interactive user sign-in.
  /// </summary>
  UserSignInSucceeded,

  /// <summary>
  /// Indicates a failed interactive user sign-in attempt.
  /// </summary>
  UserSignInFailed,

  /// <summary>
  /// Indicates a successful user registration.
  /// </summary>
  UserRegistrationSucceeded,

  /// <summary>
  /// Indicates a user sign-out event.
  /// </summary>
  UserSignOutSucceeded,

  /// <summary>
  /// Indicates a successful token issuance.
  /// </summary>
  TokenIssuanceSucceeded,

  /// <summary>
  /// Indicates a failed token issuance attempt.
  /// </summary>
  TokenIssuanceFailed,

  /// <summary>
  /// Indicates a successful token introspection request.
  /// </summary>
  TokenIntrospectionSucceeded,

  /// <summary>
  /// Indicates a failed token introspection request.
  /// </summary>
  TokenIntrospectionFailed,

  /// <summary>
  /// Indicates a successful token revocation.
  /// </summary>
  TokenRevocationSucceeded,

  /// <summary>
  /// Indicates a failed token revocation attempt.
  /// </summary>
  TokenRevocationFailed,

  /// <summary>
  /// Indicates that user consent was successfully granted for the requested scopes.
  /// </summary>
  ConsentGranted,

  /// <summary>
  /// Indicates that user consent was denied or not granted for the requested scopes.
  /// </summary>
  ConsentDenied,

  /// <summary>
  /// Indicates that an IP address was blocked for a specific identifier.
  /// </summary>
  IdentifierIpBlocked,

  /// <summary>
  /// Indicates that a user account was blocked.
  /// </summary>
  UserAccountBlocked,

  /// <summary>
  /// Indicates that a user account was unblocked.
  /// </summary>
  UserAccountUnblocked,

  /// <summary>
  /// Indicates that an IP address was blocked for a user account.
  /// </summary>
  UserAccountIpBlocked,

  /// <summary>
  /// Indicates that an IP address block was removed from a user account.
  /// </summary>
  UserAccountIpUnblocked,

  /// <summary>
  /// Indicates that all blocks were removed from a user account.
  /// </summary>
  UserAccountAllUnblocked,

  /// <summary>
  /// Indicates that all IP address blocks were removed from a user account.
  /// </summary>
  UserAccountAllIpBlocksRemoved,

  /// <summary>
  /// Indicates that a user account was successfully created.
  /// </summary>
  UserCreated,

  /// <summary>
  /// Indicates that a user account was deleted.
  /// </summary>
  UserDeleted,

  /// <summary>
  /// Indicates that a user successfully completed a password reset.
  /// </summary>
  UserPasswordResetSucceeded,

  /// <summary>
  /// Indicates that a user was added to a group.
  /// </summary>
  UserAddedToGroup,

  /// <summary>
  /// Indicates that a user was removed from a group.
  /// </summary>
  UserRemovedFromGroup,

  /// <summary>
  /// Indicates that a specific user session was revoked.
  /// </summary>
  UserSessionRevoked,

  /// <summary>
  /// Indicates that all active sessions for a user were revoked.
  /// </summary>
  UserSessionsRevokedAll,

  /// <summary>
  /// Indicates that all sessions for a user were permanently deleted.
  /// </summary>
  UserSessionsDeletedAll,

  /// <summary>
  /// Indicates that a sign-in email notification was successfully sent.
  /// </summary>
  SignInEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a verification email notification was successfully sent.
  /// </summary>
  VerificationEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a welcome email notification was successfully sent.
  /// </summary>
  WelcomeEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a password change confirmation email was successfully sent.
  /// </summary>
  PasswordChangeEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a password reset email notification was successfully sent.
  /// </summary>
  PasswordResetEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a user blocked notification email was successfully sent.
  /// </summary>
  UserBlockedEmailSendingSucceeded,

  /// <summary>
  /// Indicates that a sign-in SMS notification was successfully sent.
  /// </summary>
  SignInSmsSendingSucceeded,

  /// <summary>
  /// Indicates that a verification SMS notification was successfully sent.
  /// </summary>
  VerificationSmsSendingSucceeded,

  /// <summary>
  /// Indicates that a password reset SMS notification was successfully sent.
  /// </summary>
  PasswordResetSmsSendingSucceeded,

  /// <summary>
  /// Indicates that sending an email notification failed.
  /// </summary>
  EmailSendingFailed,

  /// <summary>
  /// Indicates that sending an SMS notification failed.
  /// </summary>
  SmsSendingFailed,

  /// <summary>
  /// Indicates that an API resource was created.
  /// </summary>
  ApiResourceCreated,

  /// <summary>
  /// Indicates that an API resource was updated.
  /// </summary>
  ApiResourceUpdated,

  /// <summary>
  /// Indicates that an API resource was deleted.
  /// </summary>
  ApiResourceDeleted,

  /// <summary>
  /// Indicates that a secret was created for an API resource.
  /// </summary>
  ApiResourceSecretCreated,

  /// <summary>
  /// Indicates that a secret was deleted from an API resource.
  /// </summary>
  ApiResourceSecretDeleted,

  /// <summary>
  /// Indicates that a client was granted access to an API resource.
  /// </summary>
  ApiResourceClientCreated,

  /// <summary>
  /// Indicates that a client's access configuration for an API resource was updated.
  /// </summary>
  ApiResourceClientUpdated,

  /// <summary>
  /// Indicates that a client's access to an API resource was removed.
  /// </summary>
  ApiResourceClientRemoved,

  /// <summary>
  /// Indicates that a trust store was created.
  /// </summary>
  TrustStoreCreated,

  /// <summary>
  /// Indicates that a trust store was updated.
  /// </summary>
  TrustStoreUpdated,

  /// <summary>
  /// Indicates that a trust store was deleted.
  /// </summary>
  TrustStoreDeleted,

  /// <summary>
  /// Indicates that a certificate revocation list (CRL) was added to the trust store.
  /// </summary>
  TrustStoreRevocationAdded,

  /// <summary>
  /// Indicates that a certificate revocation list (CRL) was removed from the trust store.
  /// </summary>
  TrustStoreRevocationRemoved,

  /// <summary>
  /// Indicates that a certificate was banned in the trust store.
  /// </summary>
  TrustStoreCertificateBanned,

  /// <summary>
  /// Indicates that a previously banned certificate was unbanned in the trust store.
  /// </summary>
  TrustStoreCertificateUnbanned,

  /// <summary>
  /// Indicates that a client application was created.
  /// </summary>
  ClientCreated,

  /// <summary>
  /// Indicates that a client application was updated.
  /// </summary>
  ClientUpdated,

  /// <summary>
  /// Indicates that a client application was deleted.
  /// </summary>
  ClientDeleted,

  /// <summary>
  /// Indicates that a client secret was created.
  /// </summary>
  ClientSecretCreated,

  /// <summary>
  /// Indicates that a client secret was deleted.
  /// </summary>
  ClientSecretDeleted,

  /// <summary>
  /// Indicates that a client application was added to a group.
  /// </summary>
  ClientAddedToGroup,

  /// <summary>
  /// Indicates that a client application was removed from a group.
  /// </summary>
  ClientRemovedFromGroup,

  /// <summary>
  /// Indicates that a group was created.
  /// </summary>
  GroupCreated,

  /// <summary>
  /// Indicates that a group was updated.
  /// </summary>
  GroupUpdated,

  /// <summary>
  /// Indicates that a group was deleted.
  /// </summary>
  GroupDeleted,

  /// <summary>
  /// Indicates that all grants associated with a user were revoked.
  /// </summary>
  UserGrantsRevoked,

  /// <summary>
  /// Indicates that an authorization code grant was revoked.
  /// </summary>
  AuthorizationCodeRevoked,

  /// <summary>
  /// Indicates that a user consent grant was revoked.
  /// </summary>
  UserConsentRevoked,

  /// <summary>
  /// Indicates that a reference token grant was revoked.
  /// </summary>
  ReferenceTokenRevoked,

  /// <summary>
  /// Indicates that a refresh token grant was revoked.
  /// </summary>
  RefreshTokenRevoked
}


