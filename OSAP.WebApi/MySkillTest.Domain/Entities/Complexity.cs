using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities;

public  class Complexity:BaseModal
{
    public Complexity()
    {
        this.AssessmentDetails = new HashSet<AssessmentDetail>();
        this.AssessmentDomainLimitTrackers = new HashSet<AssessmentDomainLimitTracker>();
        this.Questions = new HashSet<Question>();
    }
    public Guid ComplexityId { get; set; }
    public string ComplexityLevel { get; set; }=string.Empty;

    ///Navigation//

    public virtual ICollection<AssessmentDetail> AssessmentDetails { get; set; }
    public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
    public virtual ICollection<Question> Questions { get; set; }

    }
