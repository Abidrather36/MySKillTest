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
    [Table(nameof(AssessmentDomain))]
    public class AssessmentDomain : BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public string DomainShortName { get; set; }

        public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
        public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
        public virtual ICollection<AssessmentLibrary> AssessmentLibraries { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }

        [ForeignKey(nameof(CompilerId))]
        public virtual Compiler Compiler { get; set; }
        public int? CompilerId { get; set; }

        [ForeignKey(nameof(PrimaryDomainId))]
        public virtual PrimaryDomain PrimaryDomain { get; set; }
        public int? PrimaryDomainId { get; set; }

    }
}


