using System;
using System.ComponentModel.DataAnnotations;

namespace OSAP.WebApi.Models
{
    public class FileUploadModel
    {
        [Required]
        public string FileName { get; set; }
        [Required]
        public Guid UserAssessmentId { get; set; }
        public long? Size { get; set; }
        [Required]
        public byte[] FileData { get; set; }
    }

    public class FileDownloadModel
    {
        public Guid FileId { get; set; }
        public byte[] FileData { get; set; }
        public string FileName { get; set; }
    }
}