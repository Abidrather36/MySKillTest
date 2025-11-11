using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class SubmitAnswerModel
    {
        public Guid userAssessmentId { get; set; }
        public int questionId { get; set; }
        public string answer { get; set; }
        public bool isAnswerCompiled { get; set; }
    }
}