using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserRole))]
    public class UserRole:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual UserMaster UserMaster { get; set; }
        public int UserId { get; set; }

    }
}
