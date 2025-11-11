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
    public class AssessmentLibrary:BaseModal
    {
        public Guid LibraryId { get; set; }
        public string LibraryName { get; set; } = string.Empty; 

        public Guid DomainId { get; set; }


        // Navigation property
        public virtual AssessmentDomain AssessmentDomain { get; set; }
    }
}
