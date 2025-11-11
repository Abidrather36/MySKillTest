using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentTracker : BaseModal
    {
        public Guid UserAssessmentTrackerId { get; set; }
        public Guid DomainId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public Guid? QuestionId { get; set; }
        public bool Presented { get; set; }

        // Navigation properties
        public virtual AssessmentDomain AssessmentDomain { get; set; } = null!;
        public virtual Question? Question { get; set; }
        public virtual UserAssessment UserAssessment { get; set; } = null!;
    }

}
