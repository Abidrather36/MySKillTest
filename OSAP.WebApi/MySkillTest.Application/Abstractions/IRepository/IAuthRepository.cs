using MySkillTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Application.Abstractions.IRepository
{
    public interface IAuthRepository:IBaseRepository<UserMaster>
    {
    }
}
