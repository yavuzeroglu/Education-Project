using Education.Application.Abstractions.Tokens.DTOs;

namespace Education.Application.Features.AppUsers.DTOs
{
    public class LoginUserDto
    {
        
    }

    public class LoginUserSuccessResponse : LoginUserDto {
        public Token Token { get; set; }
        
    }

    public class LoginUserErrorResponse : LoginUserDto
    {
        public string Message { get; set; }
    }
}
