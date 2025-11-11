using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Models.Request
{
    public class RoleRequestModel
    {
        
            public Guid RoleId { get; set; }
            public Guid ClientId { get; set; }
            public string RoleName { get; set; } = string.Empty;
            public string LoweredRoleName { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public Guid? CreatedBy { get; set; }
            public DateTimeOffset? CreatedDate { get; set; }
    }
}
