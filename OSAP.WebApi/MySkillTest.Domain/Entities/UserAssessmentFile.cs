using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySkillTest.Domain.Domain.Shared;

namespace MySkillTest.Domain.Entities
{
    public partial class UserAssessmentFile : BaseModal
    {

        public Guid UserAssessmentFileId { get; set; }
        public Guid UserAssessmentId { get; set; }
        public string? FileName { get; set; }
        public byte[] FileContent { get; set; }

        //// Navigation property (if applicable)
        //public virtual UserAssessment? UserAssessment { get; set; }

        //Yet to Bind In ModelBinder In Fluent Api//
    //    modelBuilder.Entity<UserAssessmentFile>(entity =>
    //{
    //    entity.ToTable("UserAssessmentFile");

    //    entity.HasKey(e => e.UserAssessmentFileId);

    //    entity.Property(e => e.FileName)
    //          .IsRequired()
    //          .HasMaxLength(255);

    //    entity.Property(e => e.FileContent)
    //          .IsRequired();

    //    entity.Property(e => e.CreatedDate)
    //          .HasColumnType("datetimeoffset");

    //    entity.Property(e => e.ModifiedDate)
    //          .HasColumnType("datetimeoffset");

    //    // Relationship to UserAssessment (if exists in schema)
    //    entity.HasOne(e => e.UserAssessment)
    //          .WithMany()
    //          .HasForeignKey(e => e.UserAssessmentId)
    //          .OnDelete(DeleteBehavior.Cascade);
    //});
    }

}
