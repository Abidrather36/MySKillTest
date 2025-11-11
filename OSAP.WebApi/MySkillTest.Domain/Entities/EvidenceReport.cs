using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class EvidenceReport:BaseModal
    {
        public EvidenceReport()
        {
            this.EvidenceReportDetails = new HashSet<EvidenceReportDetail>();
        }

        public Guid EvidenceReportId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public string? StartedAt { get; set; }
        public string? FinishedAt { get; set; }
        public int? TrustScore { get; set; }
        public string? Device { get; set; }
        public string? Screen_recording_url { get; set; }
        public string? Test_taker_photo_url { get; set; }


        //Navigation and Relatuionships //
        public virtual ICollection<EvidenceReportDetail> EvidenceReportDetails { get; set; }
        public virtual UserAssessment UserAssessment { get; set; }
      

        }

    }
