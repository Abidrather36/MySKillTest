using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Abstractions.Jwt;
using MySkillTest.Application.Common;
using MySkillTest.Application.Utils;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        private readonly IJwtProvider jwtProvider;

        public AuthService(IAuthRepository authRepository, IJwtProvider jwtProvider)
        {
            this.authRepository = authRepository;
            this.jwtProvider = jwtProvider;
        }

        public async Task<ApiResponse<string>> ChangePassword(ChangePasswordModel model)
        {
            var user = await authRepository.FirstOrDefaultAsync(x => x.UserId == model.UserId);
            if (user is null)
            {
                return ApiResponse<string>.ErrorResponse(ApiMessages.Auth.InvalidCredential, HttpStatusCodes.BadRequest);

            }
            if (!AppEncryption.ComparePassword(user.Password, model.OldPassword, default))
            {
                return ApiResponse<string>.ErrorResponse(ApiMessages.Auth.IncorrectOldPassword, HttpStatusCodes.BadRequest);

            }
            user.Password = AppEncryption.CreatePassword(model.NewPassword, default);
            var updatedUserPassword = await authRepository.UpdateAsync(user);
            if (updatedUserPassword > 0)
                return ApiResponse<string>.SuccessResponse(default,ApiMessages.Auth.PasswordChangedSuccess, HttpStatusCodes.Created);

            return ApiResponse<string>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
        }

        public async Task<ApiResponse<string>> ForgotPassword(string emailOrUserName)
        {
           var user=await authRepository.FirstOrDefaultAsync(x => x.UserName == emailOrUserName);
            if (user is null)
                return ApiResponse<string>.ErrorResponse(ApiMessages.NotFound, HttpStatusCodes.BadRequest);

            return default;
        }

        public async Task<ApiResponse<LoginResponseModel>> Login(LoginRequestModel model)
        {
            try
            {
                var user = await authRepository.FirstOrDefaultAsync(x => x.UserName == model.Email);
                if (user is null)
                {
                    return ApiResponse<LoginResponseModel>.ErrorResponse("No Such User or couldnt find anyhting", HttpStatusCodes.BadRequest);
                }
                //if (!AppEncryption.ComparePassword(user.Password!, model.Password!, user.Salt!))
                //    return ApiResponse<LoginResponseModel>.ErrorResponse(ApiMessages.Auth.InvalidCredential, HttpStatusCodes.BadRequest);
                if (!AppEncryption.ComparePassword(user.Password!, model.Password!, default))
                    return ApiResponse<LoginResponseModel>.ErrorResponse(ApiMessages.Auth.InvalidCredential, HttpStatusCodes.BadRequest);
                var userTokens = jwtProvider.GenerateToken(user);

                LoginResponseModel login = new()
                {
                    UserId = user.UserId,
                    FullName = user.Name,
                    Token = userTokens.Token,
                    //IsPasswordTemporary = user.IsPasswordTemporary,
                    //UserRole = userTokens.Role ?? UserRole.PortalAdmin,
                    Email = user.UserName,
                    MobileNumber = user.MobileNo,
                };
                return ApiResponse<LoginResponseModel>.SuccessResponse(login, ApiMessages.Auth.LoggedIn, HttpStatusCodes.Accepted);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

