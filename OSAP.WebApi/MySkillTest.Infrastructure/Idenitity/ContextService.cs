using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MySkillTest.Application.Abstractions.Iidentity;

namespace MySkillTest.Infrastructure.Idenitity
{
    public class ContextService : IContextService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public ContextService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string GetEmail()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public Guid UserId()
        {
            var userId=httpContextAccessor.HttpContext!.User.Claims.FirstOrDefault(x => x.Type == AppClaims.UserId)?.Value;
            if (userId == null) return Guid.Empty;
            Guid id=Guid.Parse(userId);
            return id;  
        }
    }
}
