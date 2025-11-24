using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Domain;
using MySkillTest.Domain.Entities;
using MySkillTest.Domain.Models.Request;
using MySkillTest.Persistence.Data;
using System.Linq;

namespace MySkillTest.Persistence.Repositories
{
    public class RegisteredCompanyRepository : BaseRepository<RegisteredCompany>, IRegisteredCompanyRepository
    {
        private readonly MySkillTestDbContext context;

        public RegisteredCompanyRepository(MySkillTestDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<RegisteredCompany>> GetAllRegisteredCompanies()
        {
            var registeredCompanies = await context.RegisteredCompanies.ToListAsync();
            return registeredCompanies;
        }

        public async Task<RegisteredCompany> GetRegisteredCompanyById(int registeredCompanyId)
        {
            return await context.RegisteredCompanies.FindAsync(registeredCompanyId);
        }
        public async Task<bool> CheckIfCompanyExist(string emailAddress)
        {
            var companyExist = await context.RegisteredCompanies
                .AnyAsync(c => c.EmailAddress == emailAddress);

            if (!companyExist)
            {
                companyExist = await context.UserMasters.AnyAsync(x => x.UserName == emailAddress);
            }

            return companyExist;
        }


        public async Task<RegisteredCompany> AddRegisteredCompany(RegisteredCompany registeredCompany)
        {
            //if (registeredCompany == null)
            //{
            //    throw new ArgumentNullException(nameof(registeredCompany));
            //}

            await context.RegisteredCompanies.AddAsync(registeredCompany);
            await context.SaveChangesAsync();
            return registeredCompany;
        }

        public async Task<int> UpdateRegisteredCompany(RegisteredCompany model)
        {
            context.RegisteredCompanies.Update(model);
            return await context.SaveChangesAsync();

        }

        public async Task<RegisteredCompany> DeleteRegisteredCompany(int registeredCompanyId)
        {
            var registeredCompany = await context.Set<RegisteredCompany>().FindAsync(registeredCompanyId);
            if (registeredCompany == null)
            {
                return registeredCompany;
            }
            context.Set<RegisteredCompany>().Remove(registeredCompany);
            await context.SaveChangesAsync();
            return registeredCompany;
        }



        //Dispose - Start
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
