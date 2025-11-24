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
    [Table(nameof(AssessmentQuestion))]
    public class AssessmentQuestion:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentQuestionId { get; set; }
        public int AssessmentOrder { get; set; }

        [ForeignKey(nameof(AssessmentId))]
        public virtual Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }

    }

}
