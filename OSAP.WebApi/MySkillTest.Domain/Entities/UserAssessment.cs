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
    //    public partial class UserAssessment : BaseModal
    //    {
    //        public UserAssessment()
    //        {
    //            AssessmentDomainLimitTrackers = new HashSet<AssessmentDomainLimitTracker>();
    //            UserAssessmentTrackers = new HashSet<UserAssessmentTracker>();
    //            UserResponses = new HashSet<UserResponse>();
    //            UserAssessmentIAIs = new HashSet<UserAssessmentIAI>();
    //            EvidenceReports = new HashSet<EvidenceReport>();
    //            UserAssessmentEvidenceDetails = new HashSet<UserAssessmentEvidenceDetail>();
    //            UserAssessmentPanels = new HashSet<UserAssessmentPanel>();
    //        }
    //        public Guid UserAssessmentId { get; set; }
    //        public Guid UserId { get; set; }
    //        public Guid AssessmentId { get; set; }
    //        public Guid? Assessment1Id { get; set; }
    //        public Guid UserAssessmentStatusId { get; set; }
    //        public Guid ClientId { get; set; }
    //        public Guid? SecondaryClientId { get; set; }
    //        public DateTimeOffset? StartDateTime { get; set; }
    //        public DateTimeOffset? EndDateTime { get; set; }
    //        public int? TimeRemainingInMinutes { get; set; }
    //        public int? Attempts { get; set; }
    //        public string ShortUrl { get; set; } = string.Empty;
    //        public int? RunningScore { get; set; }
    //        public int? TotalScore { get; set; }
    //        public DateTimeOffset? StatusUpdateDateTime { get; set; }
    //        public int? StatusUpdatedBy { get; set; }


    //        //Navigation //
    //        public virtual Assessment Assessment { get; set; } = default!;
    //        public virtual Assessment? Assessment1 { get; set; }
    //        public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
    //        public virtual Client Client { get; set; }
    //        public virtual Client Client1 { get; set; }
    //        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
    //        public virtual UserAssessmentStatu UserAssessmentStatu { get; set; }
    //        //public virtual UserAssessmentStatu UserAssessmentStatu1 { get; set; }
    //        public virtual ICollection<UserResponse> UserResponses { get; set; }
    //        public virtual UserMaster UserMaster { get; set; }
    //        public virtual ICollection<UserAssessmentIAI> UserAssessmentIAIs { get; set; }
    //        public virtual ICollection<EvidenceReport> EvidenceReports { get; set; }
    //        public virtual ICollection<UserAssessmentEvidenceDetail> UserAssessmentEvidenceDetails { get; set; }
    //        public virtual ICollection<UserAssessmentPanel> UserAssessmentPanels { get; set; }
    //    }
    //}

    public partial class UserAssessment : BaseModal
    {
        public UserAssessment()
        {
            AssessmentDomainLimitTrackers = new HashSet<AssessmentDomainLimitTracker>();
            UserAssessmentTrackers = new HashSet<UserAssessmentTracker>();
            UserResponses = new HashSet<UserResponse>();
            UserAssessmentIAIs = new HashSet<UserAssessmentIAI>();
            EvidenceReports = new HashSet<EvidenceReport>();
            UserAssessmentEvidenceDetails = new HashSet<UserAssessmentEvidenceDetail>();
            UserAssessmentPanels = new HashSet<UserAssessmentPanel>();
        }

        public Guid UserAssessmentId { get; set; }
        public Guid UserId { get; set; }

        // Primary / Secondary assessments
        public Guid AssessmentId { get; set; }
        public Guid? SecondaryAssessmentId { get; set; }

        public Guid UserAssessmentStatusId { get; set; }

        // Primary / Secondary clients
        public Guid ClientId { get; set; }
        public Guid? SecondaryClientId { get; set; }

        public DateTimeOffset? StartDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public int? TimeRemainingInMinutes { get; set; }
        public int? Attempts { get; set; }
        public string ShortUrl { get; set; } = string.Empty;
        public int? RunningScore { get; set; }
        public int? TotalScore { get; set; }
        public DateTimeOffset? StatusUpdateDateTime { get; set; }
        public int? StatusUpdatedBy { get; set; }

        // Navigations
        public virtual Assessment PrimaryAssessment { get; set; } = default!;
        public virtual Assessment? SecondaryAssessment { get; set; }

        public virtual Client Client { get; set; }          // primary
        public virtual Client? SecondaryClient { get; set; } // secondary


        public virtual UserAssessmentStatu UserAssessmentStatu { get; set; } = default!;
        public virtual UserMaster UserMaster { get; set; } = default!;

        public virtual ICollection<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
        public virtual ICollection<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
        public virtual ICollection<UserResponse> UserResponses { get; set; }
        public virtual ICollection<UserAssessmentIAI> UserAssessmentIAIs { get; set; }
        public virtual ICollection<EvidenceReport> EvidenceReports { get; set; }
        public virtual ICollection<UserAssessmentEvidenceDetail> UserAssessmentEvidenceDetails { get; set; }
        public virtual ICollection<UserAssessmentPanel> UserAssessmentPanels { get; set; }
    }
}
