using MySkillTest.Domain.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySkillTest.Domain.Entities
{
    [Table(nameof(UserAssessmentProctorResult))]
    public class UserAssessmentProctorResult:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAssessmentProctorResultId { get; set; }
        public int UserAssessmentId { get; set; }
        public string ResultContent { get; set; }
        public byte[] PDFContent { get; set; }
        public bool IsActive { get; set; }
    }
}
