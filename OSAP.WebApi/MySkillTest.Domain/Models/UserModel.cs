using System;

namespace OSAP.WebApi.Models
{
    public class UserMasterModel
    {
        public int? UserId { get; set; }
        public int ClientId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string LoweredUserName { get; set; } = string.Empty;
        public DateTimeOffset LastActivityDate { get; set; }
        public string Password { get; set; }=string.Empty;
        public int PasswordFormat { get; set; }
        public string? Salt { get; set; }
        public bool IsVerified { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public DateTimeOffset LastPasswordChangedDate { get; set; }
        public DateTimeOffset LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        public int PasswordResetRequestActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public string Name { get; set; } = string.Empty;
        public long? MobileNo { get; set; }
        public int RoleId { get; set; }
    }
}