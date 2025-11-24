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
    [Table(nameof(UserAssessment))]
    public class UserAssessment:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentId { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public int? TimeRemainingInMinutes { get; set; }
        public int? Attempts { get; set; }
        public string ShortUrl { get; set; }
        public int? RunningScore { get; set; }
        public int? TotalScore { get; set; }
        public DateTimeOffset? StatusUpdateDateTime { get; set; }
        public int? StatusUpdatedBy { get; set; }

        [ForeignKey(nameof(AssessmentId))]
        public virtual Assessment Assessment { get; set; }
        public int AssessmentId { get; set; }

        public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
       
        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(UserAssessmentStatusId))]
        public virtual UserAssessmentStatu UserAssessmentStatu { get; set; }
        public int UserAssessmentStatusId { get; set; }

      
        [ForeignKey(nameof(UserId))]
        public virtual UserMaster UserMaster { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<UserAssessmentIAI> UserAssessmentIAIs { get; set; }
        public virtual ICollection<EvidenceReport> EvidenceReports { get; set; }
        public virtual ICollection<UserAssessmentEvidenceDetail> UserAssessmentEvidenceDetails { get; set; }
        public virtual ICollection<UserAssessmentPanel> UserAssessmentPanels { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }


    }
}
