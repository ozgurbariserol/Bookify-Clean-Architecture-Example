using Bookify.Application.Abstractions.Messaging;
using System.Windows.Input;

namespace Bookify.Application.Users.LogInUser;
    public sealed record LogInUserCommand(string Email, string Password) : ICommand<AccessTokenResponse>;
