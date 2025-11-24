using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(ClientLogo))]
    public class ClientLogo:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientLogoId { get; set; }
        public int ClientId { get; set; }
        public int ClientLogoGuid { get; set; }
    
        //public byte[] ClientLogoContent { get; set; }
    }

}
