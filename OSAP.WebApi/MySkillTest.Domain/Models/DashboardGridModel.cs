namespace OSAP.WebApi.Models
{
    public class DashboardGridModel
    {
        public string NoOfAssessmentsCreated { get; set; }
        public string NoOfAssessmentsActive { get; set; }
        public string NoOfAssessmentsCompleted { get; set; }
        public string NoOfAssessmentsAborted { get; set; }
    }

    public class ClientAssessmentReportModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string NoOfAssessmentCreated { get; set; }
        public string NoOfCandidatesRegistered { get; set; }
    }
}