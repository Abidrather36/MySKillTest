using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class UserRoleRequestModel
    {
        public int? UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int ClientId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
    }
}