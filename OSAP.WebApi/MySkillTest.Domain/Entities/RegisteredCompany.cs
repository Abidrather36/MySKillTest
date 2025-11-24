using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Domain
{
    [Table(nameof(RegisteredCompany))]
    public class RegisteredCompany:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int RegisteredCompanyId { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
   
}
