using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AssessmentDomainModel
    {
        public int DomainId { get; set; }
        public string DomainName { get; set; }
        public string DomainShortName { get; set; }
        public Nullable<int> PrimaryDomainId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public Nullable<int> CompilerId { get; set; }
        public CompilerModel Compiler { get; set; }
        public virtual PrimaryDomainModel PrimaryDomain { get; set; }
    }
}