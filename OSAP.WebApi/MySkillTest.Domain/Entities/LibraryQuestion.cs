using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(LibraryQuestion))]
    public class LibraryQuestion:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryQuestionId { get; set; }
        public int AssessmentOrder { get; set; }

        [ForeignKey(nameof(AssessmentId))]
        public virtual Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}
