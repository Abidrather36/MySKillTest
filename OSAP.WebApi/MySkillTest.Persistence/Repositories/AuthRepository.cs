using MySkillTest.Application.Abstractions.IRepository;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Persistence.Repositories
{
    public class AuthRepository:BaseRepository<UserMaster>,IAuthRepository
    {
        public AuthRepository(MySkillTestDbContext context):base(context)
        {
                
        }
    }
}
