using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(Client))]
    public class Client:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientConfigurationJson { get; set; }
        public string ApplicationUri { get; set; }
        public string LoweredApplicationUri { get; set; }

        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<UserAssessment> UserAssessments { get; set; }
        public virtual ICollection<UserMaster> UserMasters { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}

