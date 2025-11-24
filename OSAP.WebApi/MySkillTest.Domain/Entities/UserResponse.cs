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
    [Table(nameof(UserResponse))]
    public class UserResponse:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserResponseId { get; set; }
        public bool? IsCorrect { get; set; }
        public string Remarks { get; set; }=string.Empty;   
        public int? Rating { get; set; }


        //Navigation //

        [ForeignKey(nameof(AnswerId))]
        public virtual Answer? Answer { get; set; }
        public int AnswerId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client? Client { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question? Question { get; set; }
        public int QuestionId { get; set; }

        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment? UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }

        public virtual ICollection<UserResponseMultipleAnswer> UserResponseMultipleAnswers { get; set; }
    }
}
