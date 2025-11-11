using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Data;

namespace MySkillTest.Persistence.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly MySkillTestDbContext context;

        public RoleRepository(MySkillTestDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<int> AddRoleAsync(Role roleModel)
        {
            await context.Roles.AddAsync(roleModel);
            return await context.SaveChangesAsync();
        }

        public Task<Role> DeleteRoleAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            var roles = await context.Roles.ToListAsync();
            return roles;
        }

        public async Task<Role> GetRoleByIdAsync(Guid id)
        {
            var role = await context.Roles.FindAsync(id);
            return role;
        }

        public async Task<int> UpdateRole(Role role)
        {
            await Task.Run(() => context.Roles.Update(role));
            return await context.SaveChangesAsync();
        }
        public async Task<bool> RoleExistsAsync(Guid clientId, string roleName)
        {
            var loweredRoleName = roleName.ToLower();
            var existingRole = await GetRoleByNameAsync(clientId, loweredRoleName);
            return existingRole != null;
        }

        public async Task<Role> GetRoleByNameAsync(Guid clientId, string loweredRoleName)
        {
            return await context.Roles
                .FirstOrDefaultAsync(r => r.ClientId == clientId && r.LoweredRoleName == loweredRoleName);
        }


    }
}
