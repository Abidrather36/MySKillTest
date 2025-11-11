using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentEvidenceDetail : BaseModal
    {

        public Guid UserAssessmentEvidenceId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public string TestAttemptId { get; set; } = string.Empty;   
        public string HashedTestAttemptId { get; set; }=string.Empty;
       
        // Navigation property
        public virtual UserAssessment UserAssessment { get; set; }

    }
}
