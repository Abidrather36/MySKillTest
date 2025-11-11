using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class ClientLogo:BaseModal
    {
        public Guid ClientLogoId { get; set; }
        public Guid ClientId { get; set; }
        public Guid ClientLogoGuid { get; set; }
    
        public byte[] ClientLogoContent { get; set; }
    }

}
