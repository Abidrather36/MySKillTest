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
    [Table(nameof(ProctoringResult))]

    public class ProctoringResult:BaseModal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProctoringResultId { get; set; }
        public Guid? UserAssessmentId { get; set; }
        public string RawContent { get; set; }
        public string Identifier { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }
        public string Duration { get; set; }
        public string StartedAt { get; set; }
        public string StoppedAt { get; set; }
        public string Score { get; set; }
        public string Student { get; set; }
        public string SignedAt { get; set; }
        public string Conclusion { get; set; }
        public string AveragesB1 { get; set; }
        public string AveragesB2 { get; set; }
        public string AveragesB3 { get; set; }
        public string AveragesC1 { get; set; }
        public string AveragesC2 { get; set; }
        public string AveragesC3 { get; set; }
        public string AveragesC4 { get; set; }
        public string AveragesC5 { get; set; }
        public string AveragesK1 { get; set; }
        public string AveragesM1 { get; set; }
        public string AveragesM2 { get; set; }
        public string AveragesN1 { get; set; }
        public string AveragesN2 { get; set; }
        public string AveragesS1 { get; set; }
        public string AveragesS2 { get; set; }
        public string Verified { get; set; }
    }

}
