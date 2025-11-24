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
    [Table(nameof(Compiler))]
    public class Compiler:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompilerId { get; set; }
        public string ? CompilerName { get; set; }=string.Empty;
        public string? CompilerDescription { get; set; }

        public string? MonacoEditorName { get; set; }

        public virtual ICollection<AssessmentDomain>? AssessmentDomains { get; set; }

    }

}
