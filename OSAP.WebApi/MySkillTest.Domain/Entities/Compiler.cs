using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class Compiler:BaseModal
    {
        public Compiler()
        {
            this.AssessmentDomains = new HashSet<AssessmentDomain>();
        }

        public Guid CompilerId { get; set; }
        public string ? CompilerName { get; set; }=string.Empty;
        public string? CompilerDescription { get; set; }

        public string? MonacoEditorName { get; set; }

        public virtual ICollection<AssessmentDomain>? AssessmentDomains { get; set; }

    }

}
