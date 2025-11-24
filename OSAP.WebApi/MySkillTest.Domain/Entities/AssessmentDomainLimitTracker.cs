using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities;

[Table(nameof(AssessmentDomainLimitTracker))]
public class AssessmentDomainLimitTracker:BaseModal
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AssessmentDomainLimitTrackerId { get; set; }
    public int? AssessmentDomainLimit { get; set; }
    public int? QuestionsPresentedCount { get; set; }
  
    [ForeignKey(nameof(DomainId))]
    public virtual AssessmentDomain AssessmentDomain { get; set; }
    public int DomainId { get; set; }

    [ForeignKey(nameof(ComplexityId))]
    public virtual Complexity Complexity { get; set; }
    public int ComplexityId { get; set; }

    [ForeignKey(nameof(UserAssessmentId))]
    public virtual UserAssessment UserAssessment { get; set; }
    public int UserAssessmentId { get; set; }

}


