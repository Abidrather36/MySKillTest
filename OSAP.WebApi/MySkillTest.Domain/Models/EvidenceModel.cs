using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class EvidenceSaveModel
    {
        public System.Guid UserAssessmentId { get; set; }
        public AttemptDetailsModel AttemptDetails { get; set; }
        public List<EvidenceModel> Evidence { get; set; }
    }

    public class AttemptDetailsModel
    {
        public string StartedAt { get; set; }
        public string FinishedAt { get; set; }
        public int TrustScore { get; set; }
        public string Device { get; set; }
        public string Screen_recording_url { get; set; }
        public string Test_taker_photo_url { get; set; }
    }

    public class EvidenceModel
    {
        public string Evidence_label { get; set; }
        public DateTime Evidence_iso_datetime { get; set; }
        public bool? Is_violation { get; set; }
        public string Evidence_url { get; set; }
    }

    public class EvidenceGridModel
    {
        public System.Guid UserAssessmentId { get; set; }
        public AttemptDetailsGridModel AttemptDetails { get; set; }
        public List<EvidenceDetailsModel> Evidence { get; set; }
    }

    public class AttemptDetailsGridModel
    {
        public int EvidenceReportId { get; set; }
        public string StartedAt { get; set; }
        public string FinishedAt { get; set; }
        public int TrustScore { get; set; }
        public string Device { get; set; }
        public string Screen_recording_url { get; set; }
        public string Test_taker_photo_url { get; set; }
    }

    public class EvidenceDetailsModel
    {
        public string Evidence_label { get; set; }
        public DateTimeOffset? Evidence_iso_datetime { get; set; }
        public bool? Is_violation { get; set; }
        public string Evidence_url { get; set; }
    }
}