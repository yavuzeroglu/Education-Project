using Education.Application.Abstractions.Services.Users.DTOs;

namespace Education.Application.Abstractions.Services.Users
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        
    }
}
