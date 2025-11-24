using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserAssessmentTracker))]
    public class UserAssessmentTracker:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentTrackerId { get; set; }
        public bool? Presented { get; set; }

        [ForeignKey(nameof(DomainId))]
        public virtual AssessmentDomain AssessmentDomain { get; set; }
        public int DomainId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public int? QuestionId { get; set; }

        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }

    }
}
