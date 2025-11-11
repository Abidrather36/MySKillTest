using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentStatu:BaseModal
    {
        public UserAssessmentStatu()
        {
            this.UserAssessments = new HashSet<UserAssessment>();
            //this.UserAssessments1 = new HashSet<UserAssessment>();
        }

        public Guid UserAssessmentStatusId { get; set; }
        public string UserAssessmentStatusName { get; set; } = string.Empty;    

        public virtual ICollection<UserAssessment> UserAssessments { get; set; }
        //public virtual ICollection<UserAssessment> UserAssessments1 { get; set; }

        //Defined in Fluent Api  but commented // 
    }
  }


