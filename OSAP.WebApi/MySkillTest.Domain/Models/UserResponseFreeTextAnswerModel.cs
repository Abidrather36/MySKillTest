using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserResponseFreeTextAnswerModel
    {
        public int UserResponseFreeTextAnswerId { get; set; }
        public int UserResponseId { get; set; }
        public string Answer { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<bool> IsAnswerCompiled { get; set; }
    }
}