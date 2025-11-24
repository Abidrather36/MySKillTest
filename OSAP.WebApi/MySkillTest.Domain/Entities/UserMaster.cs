using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserMaster))]
    public class UserMaster:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public DateTimeOffset LastActivityDate { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsVerified { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public DateTimeOffset LastPasswordChangedDate { get; set; }
        public DateTimeOffset LastLockoutDate { get; set; }
        public DateTimeOffset FailedPasswordAttemptCount { get; set; }
        public bool PasswordResetRequestActive { get; set; }
        public string Name { get; set; }
        public long?MobileNo { get; set; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<UserAssessment> UserAssessments { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserAssessmentIAI> UserAssessmentIAIs { get; set; }
        public virtual ICollection<UserAssessmentPanel> UserAssessmentPanels { get; set; }
    }


}

