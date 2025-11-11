using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    
    //public partial class Answer:BaseModal
    //{
    //    public Answer()
    //    {
    //        this.UserResponses = new HashSet<UserResponse>();
    //        this.UserResponseMultipleAnswers = new HashSet<UserResponseMultipleAnswer>();
    //    }
    //    public Guid AnswerId { get; set; }
    //    public string AnswerText { get; set; }=string.Empty;
    //    public Guid QuestionId { get; set; }
    //    public int?AnswerOrder { get; set; }
    //    public bool? CorrectAnswer { get; set; }

    //    //[ForeignKey(nameof(Id))]
    //    public virtual Question Question { get; set; }
    //    public virtual ICollection<UserResponse> UserResponses { get; set; }
    //    public virtual ICollection<UserResponseMultipleAnswer> UserResponseMultipleAnswers { get; set; }
    //}

        public partial class Answer:BaseModal
        {
            public Answer()
            {
                UserResponses = new HashSet<UserResponse>();
                UserResponseMultipleAnswers = new HashSet<UserResponseMultipleAnswer>();
            }

            public Guid AnswerId { get; set; }
            public string AnswerText { get; set; } = string.Empty;
            public Guid QuestionId { get; set; }
            public int? AnswerOrder { get; set; }
            public bool? CorrectAnswer { get; set; }

            // Navigation properties
            public virtual Question Question { get; set; } = null!;
            public virtual ICollection<UserResponse> UserResponses { get; set; }
            public virtual ICollection<UserResponseMultipleAnswer> UserResponseMultipleAnswers { get; set; }
        }
    }

