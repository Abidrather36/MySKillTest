using MySkillTest.Domain.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(Role))]
    public class Role:BaseModal
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int? ClientId { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }

}



