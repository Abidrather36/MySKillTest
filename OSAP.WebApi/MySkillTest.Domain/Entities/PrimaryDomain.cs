using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public  class PrimaryDomain:BaseModal
    {
        public PrimaryDomain()
        {
            this.AssessmentDomains = new HashSet<AssessmentDomain>();
        }
        public Guid PrimaryDomainId { get; set; }
        public string PrimaryDomainName { get; set; }=string.Empty;
        public string PrimaryDomainShortName { get; set; } = string.Empty;


        //Naviagtion//
        public virtual ICollection<AssessmentDomain> AssessmentDomains { get; set; }
    }
}
