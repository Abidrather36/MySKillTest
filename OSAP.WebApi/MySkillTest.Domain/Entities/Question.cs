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
    [Table(nameof(Question))]
    public class Question:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }=string.Empty;
        public int? QuestionUniqueId { get; set; }
        public string QuestionTextFormatted { get; set; }=string.Empty ;

        [ForeignKey(nameof(DomainId))]
        public virtual AssessmentDomain AssessmentDomain { get; set; }
        public int DomainId { get; set; }

        [ForeignKey(nameof(ComplexityId))]
        public virtual Complexity Complexity { get; set; }
        public int ComplexityId { get; set; }

        [ForeignKey(nameof(QuestionTypeId))]
        public virtual QuestionType QuestionType { get; set; }
        public int QuestionTypeId { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }
        public virtual ICollection<LibraryQuestion> LibraryQuestions { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }

}
