using MySkillTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Models.Response
{
    public class LoginResponseModel
    {
        public string? FullName { get; set; }
        public UserRole UserRole { get; set; }
        public int? UserId { get; set; }
        public string? Token { get; set; }
        public string? Email { get; set; }
        public long? MobileNumber { get; set; }
        public bool IsPasswordTemporary { get; set; }
        //public string? FilePath { get; set; }
    }
}
