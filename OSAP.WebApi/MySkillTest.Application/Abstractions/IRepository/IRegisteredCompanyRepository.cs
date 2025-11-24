using MySkillTest.Domain.Domain;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IRegisteredCompanyRepository:IBaseRepository<RegisteredCompany>
    {
        Task<IEnumerable<RegisteredCompany>> GetAllRegisteredCompanies();
        Task<RegisteredCompany> GetRegisteredCompanyById(int registeredCompanyId);
        Task<bool> CheckIfCompanyExist(string emailAddress);
        Task<RegisteredCompany> AddRegisteredCompany(RegisteredCompany registeredCompany);
        Task<int> UpdateRegisteredCompany(RegisteredCompany registeredCompany);
        Task<RegisteredCompany> DeleteRegisteredCompany(int registeredCompanyId);
    }
}
