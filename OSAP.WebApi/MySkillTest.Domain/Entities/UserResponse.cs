using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserResponse:BaseModal
    {
        public UserResponse()
        {
            PrimaryMultipleAnswers = new HashSet<UserResponseMultipleAnswer>();
            SecondaryMultipleAnswers = new HashSet<UserResponseMultipleAnswer>();
        }
        public Guid UserResponseId { get; set; }
        public bool? IsCorrect { get; set; }
        public string Remarks { get; set; }=string.Empty;   
        public int? Rating { get; set; }
        public Guid UserAssessmentId { get; set; }
        public Guid ClientId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AnswerId { get; set; }

        //Navigation //
        public virtual Answer? Answer { get; set; }
        public virtual Client? Client { get; set; }
        public virtual Question? Question { get; set; }
        public virtual UserAssessment? UserAssessment { get; set; }
        public virtual ICollection<UserResponseMultipleAnswer> PrimaryMultipleAnswers { get; set; }
        public virtual ICollection<UserResponseMultipleAnswer> SecondaryMultipleAnswers { get; set; }
    }
}
