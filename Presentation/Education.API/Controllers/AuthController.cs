using Education.Application.Features.AppUsers.Commands.LoginUser;
using Education.Application.Features.AppUsers.Commands.RefreshTokenLogin;
using Education.Application.Features.AppUsers.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand loginUserCommand)
        {
            LoginUserDto response = await _mediator.Send(loginUserCommand);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenLoginCommand refreshTokenLoginCommand)
        {
            RefreshTokenLoginResponseDto response = await _mediator.Send(refreshTokenLoginCommand);
            return Ok(response);
        }
    }
}
