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
    [Table(nameof(QuestionType))]
    public class QuestionType : BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }
        public bool? MultipleChoice { get; set; }
        public bool? Coding { get; set; }
        public bool? AllowMultipleSelection { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
