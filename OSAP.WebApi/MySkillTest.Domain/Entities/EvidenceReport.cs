using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(EvidenceReport))]
    public class EvidenceReport:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EvidenceReportId { get; set; }
        public string StartedAt { get; set; }
        public string FinishedAt { get; set; }
        public int? TrustScore { get; set; }
        public string Device { get; set; }
        public string Screen_recording_url { get; set; }
        public string Test_taker_photo_url { get; set; }

        public virtual ICollection<EvidenceReportDetail> EvidenceReportDetails { get; set; }
       
        [ForeignKey(nameof(UserAssessmentId))]
        public virtual UserAssessment UserAssessment { get; set; }
        public int UserAssessmentId { get; set; }

    }
}
