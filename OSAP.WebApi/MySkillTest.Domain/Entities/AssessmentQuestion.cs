using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class AssessmentQuestion : BaseModal
    {
        public Guid AssessmentQuestionId { get; set; }
        public Guid AssessmentId { get; set; }
        public Guid QuestionId { get; set; }
        public int AssessmentOrder { get; set; }


        // Navigation properties
        public virtual Assessment Assessment { get; set; }
        public virtual Question Question { get; set; }
    }

}
