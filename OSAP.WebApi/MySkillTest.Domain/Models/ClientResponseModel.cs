using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Models
{
    public class ClientResponseModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ClientConfigurationJson { get; set; }=string.Empty;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ApplicationUri { get; set; } = string.Empty;
        public string LoweredApplicationUri { get; set; }   = string.Empty;
        public DateTimeOffset? ModifiedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Guid? DeletedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
