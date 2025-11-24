using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class RegisteredCompanyModel
    {
        public int RegisteredCompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? EmailAddress { get; set; }
        public string? MobileNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string? Country { get; set; }
        public  bool IsActive{ get; set; }
    }
}