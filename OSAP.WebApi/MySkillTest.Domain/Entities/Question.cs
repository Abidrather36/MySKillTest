using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class Question:BaseModal
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
            this.AssessmentQuestions = new HashSet<AssessmentQuestion>();
            this.LibraryQuestions = new HashSet<LibraryQuestion>();
            this.UserAssessmentTrackers = new HashSet<UserAssessmentTracker>();
            this.UserResponses = new HashSet<UserResponse>();
        }
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; }=string.Empty;
        public Guid DomainId { get; set; }
        public Guid ComplexityId { get; set; }
        public Guid QuestionTypeId { get; set; }
        public Guid? QuestionUniqueId { get; set; }
        public string QuestionTextFormatted { get; set; }=string.Empty ;

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual AssessmentDomain AssessmentDomain { get; set; }
        public virtual ICollection<AssessmentQuestion> AssessmentQuestions { get; set; }
        public virtual Complexity Complexity { get; set; }
        public virtual ICollection<LibraryQuestion> LibraryQuestions { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
    }

}
