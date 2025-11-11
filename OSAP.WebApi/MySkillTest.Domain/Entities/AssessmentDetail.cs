using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    //public class AssessmentDetail:BaseModal
    //{
    //    public Guid AssessmentDetailId { get; set; }
    //    public Guid AssessmentId { get; set; }
    //    public Guid DomainId { get; set; }
    //    public Guid ComplexityId { get; set; }
    //    public int NoOfQuestions { get; set; }
    //    public int NoOfCodingQuestions { get; set; }
    //    public int TimeLimitInMinutes { get; set; }

    //    public virtual Assessment Assessment { get; set; }
    //    public virtual Complexity Complexity { get; set; }
    //    public virtual AssessmentDomain AssessmentDomain { get; set; }
    //}
    public partial class AssessmentDetail:BaseModal
    {
        public Guid AssessmentDetailId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid DomainId { get; set; }
        public Guid ComplexityId { get; set; }
        public int NoOfQuestions { get; set; }
        public int NoOfCodingQuestions { get; set; }
        public int? TimeLimitInMinutes { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual Complexity Complexity { get; set; }
        public virtual AssessmentDomain AssessmentDomain { get; set; }
    }
}
