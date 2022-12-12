using Education.Application.Abstractions.Services.Users;
using Education.Application.Abstractions.Services.Users.DTOs;
using Education.Application.Exceptions;
using Education.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Education.Persistance.Services
{
    internal class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                UserName = model.Email,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
            }, model.Password);


            CreateUserResponse response = new() { Succeeded = result.Succeeded };


            if (result.Succeeded)
                response.Message = "Kullanici basariyla olusturulmustur";
            else
                foreach (var error in result.Errors)
                {
                    response.Message += $"{error.Code} - {error.Description}";
                }

            return response;
        }

        public async Task UpdateRefreshToken(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate)
        {
            //AppUser user = await _userManager.FindByIdAsync(user.Id);
            if (user != null) 
            {
                user.RefreshToken = refreshToken;
                user.RefreshTokenEndDate = accessTokenDate.AddSeconds(addOnAccessTokenDate);
                await _userManager.UpdateAsync(user);
            }
            else
                throw new NotFoundUserException();
        }
    }
}
