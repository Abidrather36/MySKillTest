using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserAssessmentEvidanceModel
    {
        public int UserAssessmentEvidenceId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public string TestAttemptId { get; set; }
        public string HashedTestAttemptId { get; set; }
    }
}