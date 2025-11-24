using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IUserRepository:IBaseRepository<UserMaster>
    {
        Task<IEnumerable<UserMaster>> GetAllUsers();
        Task<UserMaster> GetUserById(int UserId);
        Task<int> AddUser(UserMaster User);
        Task<int> UpdateUser(UserMaster User);
        Task<UserMaster> DeleteUser(int clietnId);
        Task<UserMaster?> GetUserByUserName(string UserName);

        Task<IEnumerable<UserMaster>> GetCompanyUsersByClientId(int ClientId);

        //Task<User> ChangePassword(int UserId, string NewPassword);
    }
}
