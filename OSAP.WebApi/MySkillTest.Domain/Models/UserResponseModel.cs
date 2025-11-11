using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserResponseModel
    {
        public int UserResponseId { get; set; }
        public System.Guid UserAssessmentId { get; set; }
        public int ClientId { get; set; }
        public int QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public Nullable<bool> IsCorrect { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }
}