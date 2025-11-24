using MySkillTest.Domain.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserResponseMultipleAnswer))]
    public class UserResponseMultipleAnswer:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserResponseAnswerId { get; set; }

        [ForeignKey(nameof(AnswerId))]
        public virtual Answer Answer { get; set; }
        public int AnswerId { get; set; }

        [ForeignKey(nameof(UserResponseId))]
        public virtual UserResponse UserResponse { get; set; }
        public int UserResponseId { get; set; }

    }
}
