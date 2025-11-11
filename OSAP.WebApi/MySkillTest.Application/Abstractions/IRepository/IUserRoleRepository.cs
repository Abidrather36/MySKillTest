using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IUserRoleRepository:IBaseRepository<UserRole>
    {
        Task<IEnumerable<UserRole>> GetAllUserRoles();
        Task<UserRole> GetUserRoleById(Guid UserRoleId);
        Task<int> AddUserRole(UserRole UserRole);
        Task<int> UpdateUserRole(UserRole UserRole);
        Task<UserRole> DeleteUserRole(Guid clietnId);
        Task<IEnumerable<UserRole>> GetUserRoleByUserId(Guid userId);
        Task<UserRole?> GetUserRole(Guid userId, Guid? roleId, Guid? clientId);
    }
}
