using System;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentModel
    {
        public System.Guid UserAssessmentId { get; set; }
        public int UserId { get; set; }
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public int PanelId { get; set; }
        public int ClientId { get; set; }
        public int UserAssessmentStatusId { get; set; }
        public Nullable<System.DateTimeOffset> StartDateTime { get; set; }
        public Nullable<System.DateTimeOffset> EndDateTime { get; set; }
        public Nullable<int> TimeRemainingInMinutes { get; set; }
        public Nullable<int> Attempts { get; set; }
        public string ShortUrl { get; set; }
        public Nullable<int> RunningScore { get; set; }
        public Nullable<int> TotalScore { get; set; }
        public Nullable<System.DateTimeOffset> StatusUpdateDateTime { get; set; }
        public Nullable<int> StatusUpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public string CCEmailIds { get; set; }
    }

    public class UserAssessmentIAIAssessmentModel
    {
        public int UserId { get; set; }
        public Guid UserIdIAI { get; set; }
        public int AssessmentId { get; set; }
        public Guid JobRequirementId { get; set; }
    }

    public class UserAssessmentGridModel
    {
        public System.Guid UserAssessmentId { get; set; }
        public int UserId { get; set; }
        public int AssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public int ClientId { get; set; }
        public string ClientNmae { get; set; }
        public int UserAssessmentStatusId { get; set; }
        public Nullable<System.DateTimeOffset> StartDateTime { get; set; }
        public Nullable<System.DateTimeOffset> EndDateTime { get; set; }
        public Nullable<int> TimeRemainingInMinutes { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Attempts { get; set; }
        public string ShortUrl { get; set; }
        public Nullable<int> RunningScore { get; set; }
        public Nullable<int> TotalScore { get; set; }
        public Nullable<int> TotalQuestions { get; set; }
        public Nullable<System.DateTimeOffset> StatusUpdateDateTime { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}