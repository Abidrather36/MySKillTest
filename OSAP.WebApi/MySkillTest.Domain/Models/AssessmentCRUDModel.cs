using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AssessmentCRUDModel
    {
        public int AssessmentId { get; set; }
        public int ClientId { get; set; }
        public string AssessmentName { get; set; }
        public int DomainId { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public Nullable<bool> IsProctorRequired { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<int> AttemptsAllowed { get; set; }
        public Nullable<bool> AllowPausing { get; set; }
        public Nullable<bool> RandomizeQuestions { get; set; }
        public Nullable<bool> ReadQuestionsFromAssessment { get; set; }
        public List<AssessmentDetailsModel> assessmentDetails { get; set; }
        public List<AssessmentSkillsModel> assessmentSkillDetails { get; set; }
    }
}