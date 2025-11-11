using System;
using System.ComponentModel.DataAnnotations;

namespace OSAP.WebApi.Models
{
    public class PrimaryDomainModel
    {
        public int PrimaryDomainId { get; set; }
        public string PrimaryDomainName { get; set; }
        public string PrimaryDomainShortName { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTimeOffset> DeletedDate { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    }
}