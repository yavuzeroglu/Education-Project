using Education.Application.Abstractions.Services.Auth;
using Education.Application.Features.AppUsers.DTOs;
using MediatR;

namespace Education.Application.Features.AppUsers.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, LoginUserDto>
    {
        private readonly IAuthService _authService;

        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<LoginUserDto> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {

            var token = await _authService.LoginAsync(request.Email, request.Password, 130);
            return new LoginUserSuccessResponse()
            {
                Token = token
            };

        }
    }
}
