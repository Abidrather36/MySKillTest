using System;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentIAIModel
    {
        public int UserAssessmentIAIId { get; set; }
        public int UserId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public Guid JobRequirementId { get; set; }
        public Guid UserIdIAI { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
    }

    public class UserAssessmentIAICRUDModel
    {
        public string EmailId { get; set; }
        public string CandidateName { get; set; }
        public string AssessmentName { get; set; }
        public Guid JobRequirementId { get; set; }
        public Guid UserIdIAI { get; set; }
    }
}