using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class UserResponseFreeTextAnswer:BaseModal
    {
        public Guid UserResponseFreeTextAnswerId { get; set; }
        public Guid UserResponseId { get; set; }
        public string Answer { get; set; }=string.Empty;
        public bool? IsAnswerCompiled { get; set; }
    }
}
