using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentPanel : BaseModal
    {
        public Guid UserAssessmentPanelId { get; set; }
        public Guid PanelId { get; set; }
        public Guid UserId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public bool? IsReviewed { get; set; }

        // Navigation properties
        public virtual UserAssessment? UserAssessment { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual UserMaster? UserMaster { get; set; }
    }
}
