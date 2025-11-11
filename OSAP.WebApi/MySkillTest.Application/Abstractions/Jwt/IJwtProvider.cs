using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Entities;
using salesTrack.Domain.Models.JWT;

namespace MySkillTest.Application.Abstractions.Jwt
{
    public interface IJwtProvider
    {
        public interface IJwtProvider
        {
            public UserTokens GenerateToken(UserMaster user);
            public UserTokens GenerateRefreshToken(UserMaster user);
        }
    }
}
