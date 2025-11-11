using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class QuestionTypeModel
    {
        public int TypeId { get; set; }
        public string TypeDescription { get; set; }
        public bool MultipleChoice { get; set; }
        public bool Coding { get; set; }
        public bool AllowMultipleSelection { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}