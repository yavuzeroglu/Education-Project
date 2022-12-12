using Education.Application.Abstractions.Services.Auth;
using Education.Application.Abstractions.Tokens.DTOs;
using Education.Application.Features.AppUsers.DTOs;
using MediatR;

namespace Education.Application.Features.AppUsers.Commands.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandHandler : IRequestHandler<RefreshTokenLoginCommand, RefreshTokenLoginResponseDto>
    {
        private readonly IAuthService _authService;

        public RefreshTokenLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<RefreshTokenLoginResponseDto> Handle(RefreshTokenLoginCommand request, CancellationToken cancellationToken)
        {
            Token token = await _authService.RefreshTokenLoginAsync(request.RefreshToken);
            return new()
            {
                Token = token
            };
        }
    }
}
