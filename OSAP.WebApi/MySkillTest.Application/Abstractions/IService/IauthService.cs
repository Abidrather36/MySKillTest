using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Domain.Models.Response;
using OSAP.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IAuthService
    {
        Task<ApiResponse<LoginResponseModel>> Login(LoginRequestModel model);
        Task<ApiResponse<string>> ChangePassword(ChangePasswordModel model);
        Task<ApiResponse<string>> ForgotPassword(string emailOrUserName);
    }
}
