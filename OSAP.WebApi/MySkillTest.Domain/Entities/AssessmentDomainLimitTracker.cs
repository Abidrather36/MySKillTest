using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities;
public partial class AssessmentDomainLimitTracker : BaseModal
{
    //public Guid AssessmentDomainLimitTrackerId { get; set; }
    //public int AssessmentDomainLimit { get; set; }
    //public int QuestionsPresentedCount { get; set; }

    //public Guid UserAssessmentId { get; set; }
    //public Guid DomainId { get; set; }
    //public Guid ComplexityId { get; set; }

    //public AssessmentDomain? AssessmentDomain { get; set; }
    //public  Complexity? Complexity { get; set; }
    //public UserAssessment? UserAssessment { get; set; }



    public Guid AssessmentDomainLimitTrackerId { get; set; }

    public Guid UserAssessmentId { get; set; }

    public Guid DomainId { get; set; }

    public Guid ComplexityId { get; set; }

    public int? AssessmentDomainLimit { get; set; }
    public int? QuestionsPresentedCount { get; set; }

    // Navigation properties
    public virtual AssessmentDomain AssessmentDomain { get; set; }
    public virtual Complexity Complexity { get; set; }
    public virtual UserAssessment UserAssessment { get; set; }
}

