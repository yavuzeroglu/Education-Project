using Education.Application.Abstractions.Services.Auth;
using Education.Application.Abstractions.Tokens;
using Education.Application.Abstractions.Tokens.DTOs;
using Education.Application.Exceptions;
using Education.Application.Features.AppUsers.DTOs;
using Education.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Education.Persistance.Services
{
    public class AuthService : IAuthService
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenHandler _tokenHandler;
        public AuthService(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, ITokenHandler tokenHandler)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenHandler = tokenHandler;
        }

        public Task<Token> FacebookLoginAsync(string authToken)
        {
            throw new NotImplementedException();
        }
        public Task GoogleLoginAsync(string idToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Token> LoginAsync(string email, string password, int accessTokenLifeTime)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new NotFoundUserException();


            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(accessTokenLifeTime);
                return token;
            }

            throw new AuthenticationErrorException();
        }
    }
}
