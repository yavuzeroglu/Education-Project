using Education.Application.Abstractions.Tokens.DTOs;

namespace Education.Application.Abstractions.Tokens
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second);
    }
}
