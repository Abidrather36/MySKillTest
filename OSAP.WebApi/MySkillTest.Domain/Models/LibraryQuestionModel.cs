using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class LibraryQuestionModel
    {
        public int LibraryQuestionId { get; set; }
        public int AssessmentId { get; set; }
        public int QuestionId { get; set; }
        public int AssessmentOrder { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}