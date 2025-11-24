using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using OSAP.WebApi.Models;

namespace MySkillTest.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterCompanyController : ControllerBase
    {
        private readonly IRegisterCompanyService registerCompanyService;

        public RegisterCompanyController(IRegisterCompanyService registerCompanyService)
        {
            this.registerCompanyService = registerCompanyService;
        }

        [HttpPost("register-Company")]
        public async Task<IActionResult> PostRegisteredCompany(RegisteredCompanyModel model)
        {
            try
            {
                var res = await registerCompanyService.RegisterCompanyAsync(model);
                return Ok(res);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpPut("update-Company")]
        public async Task<IActionResult> PutRegisteredCompany(UpdateRegisteredCompanyModel model)
        {
            try
            {
                var res = await registerCompanyService.UpdateRegisteredCompanyAsync(model);
                return Ok(res);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("getRegistered-CompanyById/{id:int}")]
        public async Task<IActionResult> GetRegisteredCompanyById(int id)
        {
            try
            {
                var registeredCompany = await registerCompanyService.GetRegisteredCompanyByIdAsync(id);
                return Ok(registeredCompany);

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        [HttpGet("getAllRegisteredCompanies")]
        public async Task<IActionResult> GetAllRegisteredCompanies()
        {
            try
            {
                var registeredCompanies = await registerCompanyService.GetRegisteredCompaniesAsync();
                return  Ok(registeredCompanies);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("delete-Company/{id:int}")]
        public async Task<IActionResult> DeleteRegisteredCompany(int id)
        {

            try
            {
              var res = await  registerCompanyService.DeleteRegisteredCompanyByIdAsync(id);
               return  Ok(res);    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
