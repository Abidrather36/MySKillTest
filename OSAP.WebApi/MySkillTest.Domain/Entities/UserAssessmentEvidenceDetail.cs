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

    [Table(nameof(UserAssessmentEvidenceDetail))]
    public class UserAssessmentEvidenceDetail:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentEvidenceId { get; set; }
        public string TestAttemptId { get; set; }
        public string HashedTestAttemptId { get; set; }

        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }

    }
}
