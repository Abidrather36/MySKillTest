using MySkillTest.Domain.Domain.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(EvidenceReportDetail))]
    public  class EvidenceReportDetail:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EvidenceReportDetailId { get; set; }
        public string Evidence_label { get; set; }
        public DateTimeOffset? Evidence_iso_datetime { get; set; }
        public bool? Is_violation { get; set; }
        public string Evidence_url { get; set; }

        [ForeignKey(nameof(EvidenceReportId))]
        public virtual EvidenceReport EvidenceReport { get; set; }
        public int EvidenceReportId { get; set; }

    }
}
