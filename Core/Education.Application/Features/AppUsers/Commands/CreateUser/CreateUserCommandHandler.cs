using Education.Application.Abstractions.Services.Users;
using Education.Application.Abstractions.Services.Users.DTOs;
using MediatR;

namespace Education.Application.Features.AppUsers.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResponse>
    {
        private readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(new()
            {
               Email = request.Email,
               FirstName = request.FirstName,
               LastName = request.LastName,
               Password = request.Password,
               PasswordConfirm = request.PasswordConfirm

            });



            return new()
            {
                Message= response.Message,
                Succeded = response.Succeeded
            };


        }
    }
}
