using Education.Application.Features.AppUsers.DTOs;
using MediatR;

namespace Education.Application.Features.AppUsers.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
