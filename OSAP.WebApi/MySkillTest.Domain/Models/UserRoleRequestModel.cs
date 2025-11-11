using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserRoleRequestModel
    {
        public Guid? UserRoleId { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public Guid ClientId { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
    }
}