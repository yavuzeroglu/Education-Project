using Education.Application.Features.AppUsers.Commands.CreateUser;
using Education.Application.Features.AppUsers.Commands.LoginUser;
using Education.Application.Features.AppUsers.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser(CreateUserCommand createUserCommand)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUserCommand);
            return Ok(response);
        }


        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand loginUserCommand)
        {
           LoginUserDto response = await _mediator.Send(loginUserCommand);
           return Ok(response);
        }
    }
}
