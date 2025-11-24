using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities;

[Table(nameof(Complexity))]
public  class Complexity:BaseModal
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ComplexityId { get; set; }
    public string ComplexityLevel { get; set; }=string.Empty;

    ///Navigation//

    public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
    public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
    public virtual ICollection<Question> Questions { get; set; }

    }
