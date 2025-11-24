using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{

    [Table(nameof(Assessment))]
    public class Assessment:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public int? AttemptsAllowed { get; set; }
        public bool? AllowPausing { get; set; }
        public bool? RandomizeQuestions { get; set; }
        public bool? ReadQuestionsFromAssessment { get; set; }
        public bool? IsFreezed { get; set; }
        public bool? IsProctorRequired { get; set; }

        public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<LibraryQuestion> LibraryQuestions { get; set; }
        public virtual ICollection<UserAssessment> UserAssessments { get; set; }
    }
}
