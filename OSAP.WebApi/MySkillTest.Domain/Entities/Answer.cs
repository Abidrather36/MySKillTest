using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{

    [Table(nameof(Answer))]
    public class Answer : BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public int? AnswerOrder { get; set; }
        public bool? CorrectAnswer { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; }
        public int QuestionId { get; set; }

        public virtual ICollection<UserResponse> UserResponses { get; set; }
        public virtual ICollection<UserResponseMultipleAnswer> UserResponseMultipleAnswers { get; set; }
    }
}

