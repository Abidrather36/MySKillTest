using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserAssessmentPanel))]
    public class UserAssessmentPanel:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentPanelId { get; set; }
        public int PanelId { get; set; }
        public bool? IsReviewed { get; set; }

        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
