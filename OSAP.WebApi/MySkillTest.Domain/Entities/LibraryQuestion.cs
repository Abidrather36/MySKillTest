using System.ComponentModel.DataAnnotations.Schema;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class LibraryQuestion:BaseModal
    {
        public Guid LibraryQuestionId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid QuestionId { get; set; }
        public int AssessmentOrder { get; set; }

        public virtual Assessment Assessment { get; set; }
        public virtual Question Question { get; set; }
    }
}
