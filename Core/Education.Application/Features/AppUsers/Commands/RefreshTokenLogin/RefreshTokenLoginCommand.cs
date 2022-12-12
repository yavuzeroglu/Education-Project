using Education.Application.Features.AppUsers.DTOs;
using MediatR;

namespace Education.Application.Features.AppUsers.Commands.RefreshTokenLogin
{
    public class RefreshTokenLoginCommand : IRequest<RefreshTokenLoginResponseDto> 
    {
        public string RefreshToken { get; set; }
    }
}
