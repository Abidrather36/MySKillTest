using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class QuestionAnswerModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int DomainId { get; set; }
        public int ComplexityId { get; set; }
        public int QuestionTypeId { get; set; }
        public string QuestionTextFormatted { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.Guid> QuestionUniqueId { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public List<AnswerModel> answers { get; set; }
    }
}