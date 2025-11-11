using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Application.Common;
using MySkillTest.Domain.Models.Request;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IService
{
    public interface IRegisterCompanyService
    {
        Task<ApiResponse<IEnumerable<RegisteredCompanyModel>>> GetRegisteredCompaniesAsync();
        Task<ApiResponse<RegisteredCompanyModel>> GetRegisteredCompanyByIdAsync(Guid id);
        Task<ApiResponse<UpdateRegisteredCompanyModel>> UpdateRegisteredCompanyAsync(UpdateRegisteredCompanyModel model);
        Task<ApiResponse<RegisteredCompanyModel>> RegisterCompanyAsync(RegisteredCompanyModel model);
        Task<ApiResponse<RegisterCompanyResponse>> DeleteRegisteredCompanyByIdAsync(Guid id);
    }
}
