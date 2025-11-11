using Microsoft.AspNetCore.Http;
using MySkillTest.Application.Abstractions.IService;

namespace MySkillTest.Application.Services
{
    public class FileService : IFileService
    {
        public Task<bool> UploadFileAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }
        private string GetPhysicalPath()
        {
            //Path.Combine(webRootPath, "Files");
            return default;
        }
        private string GetVirtualPath()
        {
            return default;
        }
    }
}
