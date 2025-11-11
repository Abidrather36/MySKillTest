using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public class ProctoringResult:BaseModal
    {

        /// <summary>
        /// Needs Attention 
        /// </summary>
        public Guid ProctoringResultId { get; set; }
        public Guid? UserAssessmentId { get; set; }
        public string RawContent { get; set; } = string.Empty;
        public string Identifier { get; set; } = string.Empty;  
        public string Link { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string StartedAt { get; set; } = string.Empty;
        public string StoppedAt { get; set; } = string.Empty;
        public string Score { get; set; } = string.Empty;
        public string Student { get; set; } = string.Empty;
        public string SignedAt { get; set; } = string.Empty;
        public string Conclusion { get; set; } = string.Empty;
        public string AveragesB1 { get; set; } = string.Empty;
        public string AveragesB2 { get; set; } = string.Empty;
        public string AveragesB3 { get; set; } = string.Empty;
        public string AveragesC1 { get; set; } = string.Empty;
        public string AveragesC2 { get; set; } = string.Empty;
        public string AveragesC3 { get; set; } = string.Empty;
        public string AveragesC4 { get; set; } = string.Empty;
        public string AveragesC5 { get; set; } = string.Empty;
        public string AveragesK1 { get; set; } = string.Empty;
        public string AveragesM1 { get; set; } = string.Empty;
        public string AveragesM2 { get; set; } = string.Empty;
        public string AveragesN1 { get; set; } = string.Empty;
        public string AveragesN2 { get; set; } = string.Empty;
        public string AveragesS1 { get; set; } = string.Empty;
        public string AveragesS2 { get; set; } = string.Empty;
        public string Verified { get; set; } = string.Empty;

        // Navigation property
        //public virtual UserAssessment? UserAssessment { get; set; }
//        modelBuilder.Entity<ProctoringResult>(entity =>
//{
//    entity.HasKey(e => e.ProctoringResultId);

//    entity.HasOne(e => e.UserAssessment)
//        .WithMany(ua => ua.ProctoringResults)
//        .HasForeignKey(e => e.UserAssessmentId)
//        .OnDelete(DeleteBehavior.Restrict);
//    });

    }
}
