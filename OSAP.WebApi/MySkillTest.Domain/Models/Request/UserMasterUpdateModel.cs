using OSAP.WebApi.Models;

namespace MySkillTest.Domain.Models.Request
{
    public class UserMasterUpdateModel:UserMasterModel
    {
        public int UserId { get; set; }
        public bool? IsActive { get; set; }
    }
}
