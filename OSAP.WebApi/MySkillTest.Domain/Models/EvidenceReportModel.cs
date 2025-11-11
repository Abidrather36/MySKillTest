using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class EvidenceReportModel
    {
        public int EvidenceReportId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public string StartedAt { get; set; }
        public string FinishedAt { get; set; }
        public Nullable<int> TrustScore { get; set; }
        public string Device { get; set; }
        public string Screen_recording_url { get; set; }
        public string Test_taker_photo_url { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }

        public IEnumerable<EvidenceReportDetailModel> EvidenceReportDetails { get; set; }
    }
}