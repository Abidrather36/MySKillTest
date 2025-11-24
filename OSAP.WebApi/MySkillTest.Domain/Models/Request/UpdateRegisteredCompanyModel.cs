using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Models.Request
{
    public class UpdateRegisteredCompanyModel
    {
        public int RegisteredCompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? EmailAddress { get; set; }
        public long MobileNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string? Country { get; set; }
        public bool? IsActive { get; set; }
    }
}
