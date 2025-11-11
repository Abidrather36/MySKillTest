using System;

namespace OSAP.WebApi.Models
{
    public class AllAssessmentsModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public Guid UserAssessmentId { get; set; }
        public int UserAssessmentStatusId { get; set; }
        public string AssessmentLink { get; set; }
        public string AssessmentName { get; set; }
        public DateTime? AssessmentCreatedDate { get; set; }
        public string AssessmentCompletedDate { get; set; }
        public string AssessmentStatus { get; set; }
        public string TotalScore { get; set; }
        public string TotalQuestions { get; set; }
    }
}