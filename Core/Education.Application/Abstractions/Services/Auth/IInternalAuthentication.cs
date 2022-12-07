using Education.Application.Abstractions.Tokens.DTOs;

namespace Education.Application.Abstractions.Services.Auth
{
    public interface IInternalAuthentication
    {
        Task<Token> LoginAsync(string email, string password, int accessTokenLifeTime);
    }
}
