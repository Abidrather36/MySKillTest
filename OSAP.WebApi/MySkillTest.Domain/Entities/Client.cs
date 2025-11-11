using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class Client : BaseModal
    {
        public Client()
        {
            this.Assessments = new HashSet<Assessment>();
            this.SecondaryAssessments = new HashSet<Assessment>();
            Roles = new HashSet<Role>();
            Roles1 = new HashSet<Role>();
            Roles2 = new HashSet<Role>();
            UserAssessments = new HashSet<UserAssessment>();
            SecondaryUserAssessments = new HashSet<UserAssessment>();
            UserMasters = new HashSet<UserMaster>();
            UserResponses = new HashSet<UserResponse>();
            UserRoles = new HashSet<UserRole>();
            UserRoles1 = new HashSet<UserRole>();
        }

        public Guid ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ClientConfigurationJson { get; set; } = string.Empty;
        public string ApplicationUri { get; set; } = string.Empty;
        public string LoweredApplicationUri { get; set; } = string.Empty;

        public virtual ICollection<Assessment> Assessments { get; set; }            
        public virtual ICollection<Assessment> SecondaryAssessments { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Role> Roles1 { get; set; }
        public virtual ICollection<Role> Roles2 { get; set; }
        public virtual ICollection<UserAssessment> UserAssessments { get; set; }   
        public virtual ICollection<UserAssessment> SecondaryUserAssessments { get; set; } // secondary

        public virtual ICollection<UserMaster> UserMasters { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles1 { get; set; }
    }
}

