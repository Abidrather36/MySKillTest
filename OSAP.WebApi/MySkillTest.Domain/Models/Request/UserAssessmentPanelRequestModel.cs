using System;
using System.Collections.Generic;

namespace OSAP.WebApi.Models.Request
{
    public class UserAssessmentPanelRequestModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int CreatedUserId { get; set; }
    }

    public class UserAssessmentGridForPanel
    {
        public Guid UserAssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public string CandidateName { get; set; }
        public bool? IsReviewed { get; set; }
    }

    public class UserResponsesUpdateModelForPanel
    {
        public Guid UserAssessmentId { get; set; }
        public List<UserResponsesUpdateModelList> UserResponses { get; set; }
        public int UserId { get; set; }
    }

    public class UserResponsesUpdateModelList
    {
        public int UserResponseId { get; set; }
        public int? Rating { get; set; }
        public string Remarks { get; set; }
        public bool IsAnswerCorrect { get; set; }
    }

    public class MapUserAssessmentRequestModel
    {
        public Guid UserAssessmentId { get; set; }
        public int PanelId { get; set; }
        public int UserId { get; set; }
    }
}