using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class UserAssessmentEvidenceDetailConfiguration:IEntityTypeConfiguration<UserAssessmentEvidenceDetail>
    {
        public void Configure(EntityTypeBuilder<UserAssessmentEvidenceDetail> entity)
        {
          
                entity.ToTable("UserAssessmentEvidenceDetail");

                entity.HasKey(e => e.UserAssessmentEvidenceId);

                entity.Property(e => e.TestAttemptId)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.HashedTestAttemptId)
                      .IsRequired()
                      .HasMaxLength(256);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.ModifiedDate)
                      .HasColumnType("datetimeoffset");

                entity.HasOne(e => e.UserAssessment)
                      .WithMany(ua => ua.UserAssessmentEvidenceDetails)
                      .HasForeignKey(e => e.UserAssessmentId)
                      .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
