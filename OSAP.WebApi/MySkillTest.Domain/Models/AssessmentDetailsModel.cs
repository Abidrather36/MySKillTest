using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AssessmentDetailsModel
    {
        public int AssessmentDetailId { get; set; }
        public int AssessmentId { get; set; }
        public int? PrimaryDomainId { get; set; }
        public int DomainId { get; set; }
        public int ComplexityId { get; set; }
        public int NoOfQuestions { get; set; }
        public int NoOfCodingQuestions { get; set; }
        public Nullable<int> TimeLimitInMinutes { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }

    public class AssessmentSkillsModel
    {
        public int AssessmentDetailId { get; set; }
        public int AssessmentId { get; set; }
        public int? PrimaryDomainId { get; set; }
        public int DomainId { get; set; }
        public int ComplexityId { get; set; }
        public int NoOfQuestions { get; set; }
        public int NoOfCodingQuestions { get; set; }
        public Nullable<int> TimeLimitInMinutes { get; set; }
        public List<AssessmentDomainModel> AssessmentDomains { get; set; }
        public List<PrimaryDomainModel> PrimaryDomains { get; set; }
    }
}