using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserAssessmentIAI))]
    public class UserAssessmentIAI:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentIAIId { get; set; }
        public int JobRequirementId { get; set; }
        public int UserIdIAI { get; set; }

        /// Nvaigation //
        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserMaster UserMaster { get; set; }
        public int UserId { get; set; }

    }
}
