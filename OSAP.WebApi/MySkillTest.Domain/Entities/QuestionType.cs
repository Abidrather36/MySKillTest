using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class QuestionType:BaseModal
    {
        public QuestionType()
        {
            this.Questions = new HashSet<Question>();
        }
        public Guid TypeId { get; set; }
        public string TypeDescription { get; set; } = string.Empty; 
        public bool? MultipleChoice { get; set; }
        public bool? Coding { get; set; }
        public bool? AllowMultipleSelection { get; set; }


        //Navigation //
        public virtual ICollection<Question> Questions { get; set; }
    }
}
