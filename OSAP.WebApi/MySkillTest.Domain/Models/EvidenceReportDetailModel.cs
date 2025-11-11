using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class EvidenceReportDetailModel
    {
        public int EvidenceReportDetailId { get; set; }
        public int EvidenceReportId { get; set; }
        public string Evidence_label { get; set; }
        public Nullable<System.DateTimeOffset> Evidence_iso_datetime { get; set; }
        public Nullable<bool> Is_violation { get; set; }
        public string Evidence_url { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    }
}