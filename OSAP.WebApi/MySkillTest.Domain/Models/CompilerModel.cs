using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class CompilerModel
    {
        public int CompilerId { get; set; }
        public string CompilerName { get; set; }
        public string CompilerDescription { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public string MonacoEditorName { get; set; }
    }
}