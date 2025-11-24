namespace MySkillTest.Domain.Domain.Shared
{
    public class BaseModal
    {
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
    }
}
