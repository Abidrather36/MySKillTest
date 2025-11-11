using System.ComponentModel.DataAnnotations.Schema;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentIAI:BaseModal
    {
        public Guid UserAssessmentIAIId { get; set; }
        public Guid UserId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public Guid JobRequirementId { get; set; }
        public Guid UserIdIAI { get; set; }

        /// Nvaigation //
        public virtual UserAssessment UserAssessment { get; set; }
        public virtual UserMaster UserMaster { get; set; }

    }
}
