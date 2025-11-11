using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentTrackerModel
    {
        public int UserAssessmentTrackerId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public int DomainId { get; set; }
        public Nullable<int> QuestionId { get; set; }
        public Nullable<bool> Presented { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }
}