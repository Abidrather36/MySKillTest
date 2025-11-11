using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class EvidenceReportDetail: BaseModal
    {

        public Guid EvidenceReportDetailId { get; set; }
        public Guid EvidenceReportId { get; set; }
        public string? Evidence_label { get; set; }
        public DateTimeOffset? Evidence_iso_datetime { get; set; }
        public bool? Is_violation { get; set; }
        public string? Evidence_url { get; set; }

        //Navigation //
        public virtual EvidenceReport? EvidenceReport { get; set; }
    }
}
