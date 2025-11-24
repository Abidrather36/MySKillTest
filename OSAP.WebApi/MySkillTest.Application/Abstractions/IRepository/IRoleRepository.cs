using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IRoleRepository:IBaseRepository<Role>
    {
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task<Role> GetRoleByIdAsync(int id);
        Task<int> AddRoleAsync(Role roleModel);
        Task<Role> DeleteRoleAsync(int id);
        Task<int> UpdateRole(Role role);
        Task<Role> GetRoleByNameAsync(int? clientId, string loweredRoleName);
        Task<bool> RoleExistsAsync(int? clientId, string roleName);
    }
}
