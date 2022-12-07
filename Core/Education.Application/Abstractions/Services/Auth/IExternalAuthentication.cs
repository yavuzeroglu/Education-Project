using Education.Application.Abstractions.Tokens.DTOs;

namespace Education.Application.Abstractions.Services.Auth
{
    public interface IExternalAuthentication
    {
        Task<Token> FacebookLoginAsync(string authToken);
        Task GoogleLoginAsync(string idToken);
    }
}
