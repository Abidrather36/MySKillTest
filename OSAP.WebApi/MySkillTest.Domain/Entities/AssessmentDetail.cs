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
    [Table(nameof(AssessmentDetail))]
    public class AssessmentDetail:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentDetailId { get; set; }
        public int NoOfQuestions { get; set; }
        public int NoOfCodingQuestions { get; set; }
        public int? TimeLimitInMinutes { get; set; }

        [ForeignKey(nameof(AssessmentId))]
        public virtual Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }


        [ForeignKey(nameof(ComplexityId))]
        public int ComplexityId { get; set; }
        public virtual Complexity Complexity { get; set; }

        [ForeignKey(nameof(DomainId))]
        public virtual AssessmentDomain AssessmentDomain { get; set; }
        public int DomainId { get; set; }

    }
}
