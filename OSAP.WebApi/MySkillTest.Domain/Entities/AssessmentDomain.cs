using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class AssessmentDomain : BaseModal
    {




        public AssessmentDomain()
        {
            AssessmentDetails = new HashSet<AssessmentDetail>();
            AssessmentDomainLimitTrackers = new HashSet<AssessmentDomainLimitTracker>();
            AssessmentLibraries = new HashSet<AssessmentLibrary>();
            Questions = new HashSet<Question>();
            UserAssessmentTrackers = new HashSet<UserAssessmentTracker>();
        }

        public Guid DomainId { get; set; }
        public string DomainName { get; set; } = string.Empty;
        public string DomainShortName { get; set; } = string.Empty;
        public Guid? CompilerId { get; set; }
        public Guid? PrimaryDomainId { get; set; }

        // Navigation Properties
        public virtual Compiler? Compiler { get; set; }
        [ForeignKey(nameof(PrimaryDomainId))]
        public virtual PrimaryDomain? PrimaryDomain { get; set; }
        public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
        public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
        public virtual ICollection<AssessmentLibrary> AssessmentLibraries { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
    }
}


