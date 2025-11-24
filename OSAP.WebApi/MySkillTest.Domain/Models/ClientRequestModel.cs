using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class ClientRequestModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }=string.Empty;
        public string ClientConfigurationJson { get; set; }= string.Empty;        
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string ApplicationUri { get; set; } = string.Empty;
        public string LoweredApplicationUri { get; set; } = string.Empty;
        public DateTimeOffset? ModifiedDate { get; set; }
        public DateTimeOffset? DeletedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? DeletedBy { get; set; }
    }
}