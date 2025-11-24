using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserAssessmentFile))]
    public class UserAssessmentFile : BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentFileId { get; set; }
        public int UserAssessmentId { get; set; }
        public string? FileName { get; set; }
        public byte[] FileContent { get; set; }

    }

}
