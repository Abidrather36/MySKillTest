using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Data;

namespace MySkillTest.Persistence.Repositories
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        private readonly MySkillTestDbContext context;

        public UserRoleRepository(MySkillTestDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<UserRole>> GetAllUserRoles()
        {
            var userRoles = await context.UserRoles.ToListAsync();
            return userRoles;
        }
        public async Task<UserRole?> GetUserRole(Guid userId, Guid? roleId, Guid? clientId)
        {
            return await context.UserRoles
                .FirstOrDefaultAsync(ur => ur.UserId == userId
                                        && ur.RoleId == roleId
                                        && ur.ClientId == clientId);
        }
        public async Task<UserRole> GetUserRoleById(Guid userRoleId)
        {
            return await this.context.UserRoles.FindAsync(userRoleId);
        }

        public async Task<int> AddUserRole(UserRole userRole)
        {
            if (userRole == null)
            {
                throw new ArgumentNullException(nameof(userRole));
            }

            await context.UserRoles.AddAsync(userRole);
           return  await context.SaveChangesAsync();
        }

        public async Task<int> UpdateUserRole(UserRole userRole)
        {
            await Task.Run(()=>context.UserRoles.Update(userRole));
            return   await context.SaveChangesAsync();
          
        }

        public async Task<UserRole> DeleteUserRole(Guid userRoleId)
        {
            var userRole = await context.Set<UserRole>().FindAsync(userRoleId);
            if (userRole == null)
            {
                return userRole;
            }
            context.Set<UserRole>().Remove(userRole);
            await context.SaveChangesAsync();
            return userRole;
        }

        public async Task<IEnumerable<UserRole>> GetUserRoleByUserId(Guid userId)
        {
            var userRoles = await context.UserRoles.Where(u => u.UserId == userId).ToListAsync();
            return userRoles;
        }

        //Dispose - Start
        //private bool disposed = false;

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            context.Dispose();
        //        }
        //    }
        //    this.disposed = true;
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
