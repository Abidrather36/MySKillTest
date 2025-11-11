using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Data;

namespace MySkillTest.Persistence.Repositories
{
    public class UserRepository:BaseRepository<UserMaster>,IUserRepository
    {
        private readonly MySkillTestDbContext context;

        public UserRepository(MySkillTestDbContext context ):base(context) 
        {
            this.context = context;
        }

        public async  Task<int> AddUser(UserMaster User)
        {
            if (User == null)
            {
                throw new ArgumentNullException(nameof(User));
            }

            await context.UserMasters.AddAsync(User);
            return  await context.SaveChangesAsync();
        }

        public Task<UserMaster> DeleteUser(Guid clietnId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserMaster>> GetAllUsers()
        {
           return await context.UserMasters.Include(u => u.Client).ToListAsync();
        }

        public async Task<IEnumerable<UserMaster>> GetCompanyUsersByClientId(Guid clientId)
        {
            return await context.UserMasters
                .Where(u => u.Client.ClientId == clientId)
                .ToListAsync();
        }


        public async  Task<UserMaster> GetUserById(Guid UserId)
        {
          return await context.UserMasters.FindAsync(UserId);
        }

        public async  Task<UserMaster?> GetUserByUserName(string UserName)
        {
            if (string.IsNullOrWhiteSpace(UserName))
                throw new ArgumentException("Username cannot be null or empty.", nameof(UserName));

            return await context.UserMasters
                .FirstOrDefaultAsync(user => user.UserName.ToLower() == UserName.ToLower());
        }

        public async Task<int> UpdateUser(UserMaster User)
        {
             var res= Task.Run(()=> context.UserMasters.Update(User));
             return await context.SaveChangesAsync();
        }
    }
}
