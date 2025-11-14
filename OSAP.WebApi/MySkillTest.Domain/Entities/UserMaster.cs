using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserMaster : BaseModal
    {
        public UserMaster()
        {
            this.UserAssessments = new HashSet<UserAssessment>();
            this.UserRoles = new HashSet<UserRole>();
            this.UserAssessmentIAIs = new HashSet<UserAssessmentIAI>();
            this.UserAssessmentPanels = new HashSet<UserAssessmentPanel>();
        }

        public Guid UserId { get; set; }
        public Guid ClientId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string LoweredUserName { get; set; } = string.Empty;
        public DateTimeOffset LastActivityDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public int PasswordFormat { get; set; }
        public string Salt { get; set; } = string.Empty;
        public bool IsVerified { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public DateTimeOffset LastPasswordChangedDate { get; set; }
        public DateTimeOffset LastLockoutDate { get; set; }
        public int? FailedPasswordAttemptCount { get; set; }
        public bool PasswordResetRequestActive { get; set; }
        public int? ResetCode {  get; set; }
        public DateTimeOffset? ResetExpiry { get; set; }
        public string? Name { get; set; }
        public long? MobileNo { get; set; }

        // Navigation properties
        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }

        public ICollection<UserAssessment> UserAssessments { get; set; } = new List<UserAssessment>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<UserAssessmentIAI> UserAssessmentIAIs { get; set; } = new List<UserAssessmentIAI>();
        public ICollection<UserAssessmentPanel> UserAssessmentPanels { get; set; } = new List<UserAssessmentPanel>();
    }


}

