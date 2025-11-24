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
    [Table(nameof(UserAssessmentStatu))]
    public class UserAssessmentStatu:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentStatusId { get; set; }
        public string UserAssessmentStatusName { get; set; }

        public virtual ICollection<UserAssessment> UserAssessments { get; set; }
    }
}


