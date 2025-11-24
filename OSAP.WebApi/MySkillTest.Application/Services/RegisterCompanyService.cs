using Microsoft.Extensions.Options;
using MySkillTest.Application.Abstractions.IEmailService;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Application.Abstractions.IService;
using MySkillTest.Application.Common;
using MySkillTest.Application.Utils;
using MySkillTest.Domain.Domain;
using MySkillTest.Domain.Models.Request;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Services
{
    public class RegisterCompanyService : IRegisterCompanyService
    {
        private readonly IRegisteredCompanyRepository registeredCompanyRepository;
        private readonly EmailSettings emailSettings;
        private readonly IEmailService emailService;
        private readonly IUserRepository userRepository;

        public RegisterCompanyService(IRegisteredCompanyRepository registeredCompanyRepository, IOptions<EmailSettings> options, IEmailService emailService, IUserRepository userRepository)
        {
            this.registeredCompanyRepository = registeredCompanyRepository;
            this.emailSettings = options.Value;
            this.emailService = emailService;
            this.userRepository = userRepository;
        }

        public Task<ApiResponse<int>> DeleteRegisteredCompanyAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse<IEnumerable<RegisteredCompanyModel>>> GetRegisteredCompaniesAsync()
        {
           var companies=await registeredCompanyRepository.GetAllRegisteredCompanies();
            if(companies ==null || !companies.Any())
            {
                return ApiResponse<IEnumerable<RegisteredCompanyModel>>.ErrorResponse(ApiMessages.CompanyManagement.CompanyNotFound, HttpStatusCodes.BadRequest);
            }
           var res= companies.Select(x => new RegisteredCompanyModel
            {
                RegisteredCompanyId = x.RegisteredCompanyId,
                EmailAddress= x.EmailAddress,
                CreatedDate=x.CreatedDate,
                CompanyName = x.CompanyName,
                IsActive = x.IsActive,
                Country = x.Country,
                MobileNumber = x.MobileNumber,

            });
            return ApiResponse<IEnumerable<RegisteredCompanyModel>>.SuccessResponse(res, $"{res.Count()} Companies found", HttpStatusCodes.OK); ;
        }

        public async Task<ApiResponse<RegisteredCompanyModel>> GetRegisteredCompanyByIdAsync(int id)
        {
            var regCompany = await registeredCompanyRepository.GetRegisteredCompanyById(id);
            if (regCompany == null)
            {
                return ApiResponse<RegisteredCompanyModel>.ErrorResponse(ApiMessages.CompanyManagement.CompanyNotFound, HttpStatusCodes.BadRequest);
            }
            RegisteredCompanyModel model = new()
            {
                RegisteredCompanyId = regCompany.RegisteredCompanyId,
                EmailAddress = regCompany.EmailAddress,
                CompanyName = regCompany.CompanyName,
                CreatedBy = regCompany.CreatedBy,
                Country = regCompany.Country,
                MobileNumber=regCompany.MobileNumber,
                CreatedDate = regCompany.CreatedDate,
            };
            return ApiResponse<RegisteredCompanyModel>.SuccessResponse(model, ApiMessages.CompanyManagement.CompanyFound, HttpStatusCodes.OK); ;
        }

        public async Task<ApiResponse<RegisteredCompanyModel>> RegisterCompanyAsync(RegisteredCompanyModel model)
        {
            try
            {
                var companyExist = await registeredCompanyRepository.CheckIfCompanyExist(model.EmailAddress);
                if (!companyExist)
                {

                    RegisteredCompany registeredCompany = new RegisteredCompany()
                    {
                        EmailAddress = model.EmailAddress,
                        CompanyName = model.CompanyName,
                        MobileNumber = model.MobileNumber.ToString(),
                        Country = model.Country,
                        CreatedDate = DateTimeOffset.Now

                    };
                    await registeredCompanyRepository.AddRegisteredCompany(registeredCompany);

                    var res = await emailService.SendNewCompanyRegisteredEmailAsync(model);
                    model.RegisteredCompanyId = registeredCompany.RegisteredCompanyId;
                    return ApiResponse<RegisteredCompanyModel>.SuccessResponse(model, ApiMessages.CompanyManagement.CompanyAddedSuccessfully);

                }
                {
                    return ApiResponse<RegisteredCompanyModel>.ErrorResponse(ApiMessages.CompanyManagement.CompanyAlreadyExists, HttpStatusCodes.Conflict);
                }
            }
            catch (Exception ex)
            {
                return ApiResponse<RegisteredCompanyModel>.ErrorResponse($"{ApiMessages.TechnicalError} {ex.Message} ", HttpStatusCodes.BadRequest);
            }
        }




        public async Task<ApiResponse<RegisterCompanyResponse>> DeleteRegisteredCompanyByIdAsync(int id)
        {
            var company = await registeredCompanyRepository.GetRegisteredCompanyById(id);

            if (company is null)
            {
                return ApiResponse<RegisterCompanyResponse>.ErrorResponse(ApiMessages.CompanyManagement.CompanyNotFound, HttpStatusCodes.BadRequest);
            }

            company.IsActive = false;
            company.ModifiedDate = DateTimeOffset.Now;
            var companyDeleted = await registeredCompanyRepository.UpdateAsync(company);
            RegisterCompanyResponse response = new RegisterCompanyResponse()
            {
                RegisteredCompanyId = company.RegisteredCompanyId,
                IsActive = company.IsActive,

            };

            if (companyDeleted > 0)
            {
                return ApiResponse<RegisterCompanyResponse>.SuccessResponse(response, ApiMessages.CompanyManagement.CompanyDeletedSuccessfully, HttpStatusCodes.OK);
            }

            return ApiResponse<RegisterCompanyResponse>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
        }

        public async Task<ApiResponse<UpdateRegisteredCompanyModel>> UpdateRegisteredCompanyAsync(UpdateRegisteredCompanyModel model)
        {
            var company = await registeredCompanyRepository.GetRegisteredCompanyById(model.RegisteredCompanyId);
            if (company is null)
            {
                return ApiResponse<UpdateRegisteredCompanyModel>.ErrorResponse(ApiMessages.CompanyManagement.CompanyNotFound, HttpStatusCodes.BadRequest);
            }
            company.CompanyName = model.CompanyName;
            company.ModifiedDate = DateTimeOffset.Now;
            company.Country = model.Country;
            company.IsActive = model.IsActive ?? company.IsActive;
            var updatedCompany = await registeredCompanyRepository.UpdateRegisteredCompany(company);

            if (updatedCompany > 0)
            {
                UpdateRegisteredCompanyModel res = new()
                {
                    RegisteredCompanyId = company.RegisteredCompanyId,
                    CompanyName = company.CompanyName,
                    EmailAddress = company.EmailAddress,

                };
                return ApiResponse<UpdateRegisteredCompanyModel>.SuccessResponse(res, ApiMessages.CompanyManagement.CompanyUpdatedSuccessfully, HttpStatusCodes.OK); ;

            }

            return ApiResponse<UpdateRegisteredCompanyModel>.ErrorResponse(ApiMessages.TechnicalError, HttpStatusCodes.BadRequest);
        }
    }
}
