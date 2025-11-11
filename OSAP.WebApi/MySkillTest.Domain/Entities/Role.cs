using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class Role : BaseModal
    {
        public Guid RoleId { get; set; }
        public Guid ClientId { get; set; }
        public Guid? Client1Id { get; set; }
        public Guid? Client2Id { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }

   
        public virtual Client? Client { get; set; }
        public virtual Client? Client1 { get; set; }
        public virtual Client? Client2 { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
        public virtual ICollection<UserRole> UserRoles1 { get; set; } = new HashSet<UserRole>();
    }

}



