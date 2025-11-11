using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class Assessment : BaseModal
    {
        public Assessment()
        {
            this.AssessmentDetails = new HashSet<AssessmentDetail>();
            this.AssessmentQuestions = new HashSet<AssessmentQuestion>();
            this.LibraryQuestions = new HashSet<LibraryQuestion>();
            UserAssessments = new HashSet<UserAssessment>();
            SecondaryUserAssessments = new HashSet<UserAssessment>();
        }

        public Guid AssessmentId { get; set; }
        public Guid ClientId { get; set; }                  // Primary client FK
        public Guid? SecondaryClientId { get; set; }        // Secondary client FK

        public string AssessmentName { get; set; } = string.Empty;
        public int TimeLimitInMinutes { get; set; }
        public int? AttemptsAllowed { get; set; }
        public bool? AllowPausing { get; set; }
        public bool? RandomizeQuestions { get; set; }
        public bool? ReadQuestionsFromAssessment { get; set; }
        public bool? IsFreezed { get; set; }
        public bool? IsProctorRequired { get; set; }

        public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }

        public virtual Client PrimaryClient { get; set; }
        public virtual Client SecondaryClient { get; set; }


        public virtual ICollection<LibraryQuestion> LibraryQuestions { get; set; }
        public virtual ICollection<UserAssessment> UserAssessments { get; set; }   // primary
        public virtual ICollection<UserAssessment> SecondaryUserAssessments { get; set; } // secondary

    }
}
