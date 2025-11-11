using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IRoleRepository:IBaseRepository<Role>
    {
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task<Role> GetRoleByIdAsync(Guid id);
        Task<int> AddRoleAsync(Role roleModel);
        Task<Role> DeleteRoleAsync(Guid id);
        Task<int> UpdateRole(Role role);
        Task<Role> GetRoleByNameAsync(Guid clientId, string loweredRoleName);
        Task<bool> RoleExistsAsync(Guid clientId, string roleName);
    }
}
