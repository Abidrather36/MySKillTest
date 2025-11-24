using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Models.Request
{
    public class RoleRequestModel
    {
        
            public int RoleId { get; set; }
            public int? ClientId { get; set; }
            public string RoleName { get; set; } = string.Empty;
            public string LoweredRoleName { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public int? CreatedBy { get; set; }
            public DateTimeOffset? CreatedDate { get; set; }
    }
}
