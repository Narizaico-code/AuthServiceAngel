using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace AuthServiceAngel.Application.Extensions;

public static partial class LoggerExtensions
{
    [LoggerMessage(
        EventId = 1001,
        Level = LogLevel.Information,
        Message = "User '{username}' has registered successfully.")]
    public static partial void LogUserRegistered(this ILogger logger, string username);

    [LoggerMessage(
        EventId = 1002,
        Level = LogLevel.Information,
        Message = "User login successfully.")]
    public static partial void LogUserLoggedIn(this ILogger logger, string username);

    [LoggerMessage(
        EventId = 1003,
        Level = LogLevel.Warning,
        Message = "Failed login attempt.")]
    public static partial void LogFailedLoginAttempt(this ILogger logger, string username);

    [LoggerMessage(
        EventId = 1004,
        Level = LogLevel.Warning,
        Message = "Registration reject: Email already exists.")]
    public static partial void LogRegistrationiWithExistingEmail(this ILogger logger, string email);

    [LoggerMessage(
        EventId = 1005,
        Level = LogLevel.Warning,
        Message = "Registration reject: Username already exists.")]
    public static partial void LogRegistrationWithExistingUsername(this ILogger logger, string username);

    [LoggerMessage(
        EventId = 1006,
        Level = LogLevel.Error,
        Message = "Error uploading profile image.")]
    public static partial void LogImageUploadError(this ILogger logger);
}