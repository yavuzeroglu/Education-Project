using Education.Application.Abstractions.Services.Users.DTOs;
using Education.Domain.Entities.Identity;

namespace Education.Application.Abstractions.Services.Users
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
        
    }
}
