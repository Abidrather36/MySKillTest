using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IUserRoleRepository:IBaseRepository<UserRole>
    {
        Task<IEnumerable<UserRole>> GetAllUserRoles();
        Task<UserRole> GetUserRoleById(int UserRoleId);
        Task<int> AddUserRole(UserRole UserRole);
        Task<int> UpdateUserRole(UserRole UserRole);
        Task<UserRole> DeleteUserRole(int clietnId);
        Task<IEnumerable<UserRole>> GetUserRoleByUserId(int userId);
        Task<UserRole?> GetUserRole(int userId, int? roleId, int? clientId);
    }
}
