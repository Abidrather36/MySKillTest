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
    [Table(nameof(AssessmentLibrary))]
    public class AssessmentLibrary:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibraryId { get; set; }
        public string LibraryName { get; set; }

        [ForeignKey(nameof(DomainId))]
        public virtual AssessmentDomain AssessmentDomain { get; set; }
        public int DomainId { get; set; }

    }
}
