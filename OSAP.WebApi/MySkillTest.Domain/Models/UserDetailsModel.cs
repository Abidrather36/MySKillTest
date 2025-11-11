using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserDetailsModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int ClientId { get; set; }
        public string Password { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public string AssessmentName { get; set; }
        public Nullable<System.DateTime> AssessmentCreatedDate { get; set; }
        public string AssessmentEndDate { get; set; }
        public int UserAssessmentStatusId { get; set; }
        public Nullable<int> TotalScore { get; set; }
        public Nullable<int> TotalQuestions { get; set; }
    }

    public class UsersByAssessmentModel
    {

    }
}