using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using OSAP.WebApi.Models;

namespace MySkillTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestModel model)
        {
            try
            {
                return Ok(await authService.Login(model));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPost("ChangePassword")]

        public async Task<ApiResponse<string>> ChangePassword(ChangePasswordModel model)
        {
            try
            {
                return await authService.ChangePassword(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //[HttpPost("forgetPassword/{email}")]

        //public async Task<ApiResponse<string>> ForgetPassword(string email)
        //{
        //    try
        //    {
        //        return await authService.ForgotPassword(email);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
        //[HttpPost("Reset-Password")]

        //public async Task<ApiResponse<string>> ResetPassword(ResetPasswordModel model)
        //{
        //    try
        //    {
        //        return await authService.ResetPassword(model);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}
    }
}
