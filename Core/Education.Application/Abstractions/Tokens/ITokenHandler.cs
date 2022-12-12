using Education.Application.Abstractions.Tokens.DTOs;
using Education.Domain.Entities.Identity;

namespace Education.Application.Abstractions.Tokens
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second, AppUser user);
        string CreateRefreshToken();
    }
}
