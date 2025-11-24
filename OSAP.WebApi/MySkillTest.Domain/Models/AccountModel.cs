using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OSAP.WebApi.Models
{
    public class AccountModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
    public class ChangePasswordModel
    {
        public int? UserId { get; set; }


        [Required(ErrorMessage = "Enter Old Password")]
        public string OldPassword { get; set; } = string.Empty;


        [Required(ErrorMessage = "Enter New password")]
        public string NewPassword { get; set; } = string.Empty;


        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}