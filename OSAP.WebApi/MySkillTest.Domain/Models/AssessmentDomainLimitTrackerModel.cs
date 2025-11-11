using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AssessmentDomainLimitTrackerModel
    {
        public int AssessmentDomainLimitTrackerId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public int DomainId { get; set; }
        public int ComplexityId { get; set; }
        public Nullable<int> AssessmentDomainLimit { get; set; }
        public Nullable<int> QuestionsPresentedCount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }
}