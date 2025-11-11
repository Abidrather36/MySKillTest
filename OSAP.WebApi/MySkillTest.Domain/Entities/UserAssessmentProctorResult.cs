using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentProctorResult:BaseModal
    {
        public Guid UserAssessmentProctorResultId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public string ResultContent { get; set; } = string.Empty;
        public byte[] PDFContent { get; set; }

        //// Navigation
        //public virtual UserAssessment? UserAssessment { get; set; }
        //yet to Insert into Fluent Api//
//        modelBuilder.Entity<UserAssessmentProctorResult>(entity =>
//{
//    entity.ToTable("UserAssessmentProctorResult");

//    entity.HasKey(e => e.UserAssessmentProctorResultId);

//    entity.Property(e => e.ResultContent)
//          .HasColumnType("nvarchar(max)");

//        entity.Property(e => e.PdfContent)
//          .HasColumnName("PDFContent");

//        entity.Property(e => e.CreatedDate)
//          .HasColumnType("datetimeoffset");

//        entity.Property(e => e.ModifiedDate)
//          .HasColumnType("datetimeoffset");

//        // Relationship
//        entity.HasOne(e => e.UserAssessment)
//          .WithMany(ua => ua.UserAssessmentProctorResults)
//          .HasForeignKey(e => e.UserAssessmentId)
//          .OnDelete(DeleteBehavior.Cascade);
//    });
    }

}
