using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserRole:BaseModal
    {
        public Guid UserRoleId { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }       // For Role
        public Guid? Role1Id { get; set; }     // For Role1

        public Guid ClientId { get; set; }     // For Client
        public Guid? Client1Id { get; set; }

        public virtual Client? Client { get; set; }
        public virtual Client? Client1 { get; set; }
        public virtual Role? Role { get; set; }
        public virtual Role? Role1 { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public virtual UserMaster UserMaster { get; set; }
    }
}
