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
    [Table(nameof(UserResponseFreeTextAnswer))]
    public class UserResponseFreeTextAnswer:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserResponseFreeTextAnswerId { get; set; }
        public int UserResponseId { get; set; }
        public string Answer { get; set; }
        public bool? IsAnswerCompiled { get; set; }
    }
}
