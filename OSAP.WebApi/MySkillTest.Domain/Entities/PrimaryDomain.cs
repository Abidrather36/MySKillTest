using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(PrimaryDomain))]
    public  class PrimaryDomain:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrimaryDomainId { get; set; }
        public string PrimaryDomainName { get; set; }=string.Empty;
        public string PrimaryDomainShortName { get; set; } = string.Empty;

        //Naviagtion//
        public virtual ICollection<AssessmentDomain> AssessmentDomains { get; set; }
    }
}
