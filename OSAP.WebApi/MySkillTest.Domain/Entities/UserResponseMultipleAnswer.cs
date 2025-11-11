using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class UserResponseMultipleAnswer:BaseModal
    {
        public Guid UserResponseAnswerId { get; set; }
        public Guid? PrimaryUserResponseId { get; set; }
        public Guid? SecondaryUserResponseId { get; set; }
        public Guid UserResponseId { get; set; }
        public Guid AnswerId { get; set; }

        public virtual Answer Answer { get; set; }

        public virtual UserResponse? PrimaryUserResponse { get; set; }
        public virtual UserResponse? SecondaryUserResponse { get; set; }
    }
}
