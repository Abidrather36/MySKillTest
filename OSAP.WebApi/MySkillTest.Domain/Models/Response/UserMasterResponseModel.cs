using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Models.Request;

namespace MySkillTest.Domain.Models.Response
{
    public class UserMasterResponseModel:UserMasterUpdateModel
    {
        public string ClientName { get; set; } = string.Empty;
    }
}
