using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class UserAssessmentStatuConfiguration:IEntityTypeConfiguration<UserAssessmentStatu>
    {
        public void Configure(EntityTypeBuilder<UserAssessmentStatu> entity)
        {
             entity.ToTable("UserAssessmentStatu");

                entity.HasKey(e => e.UserAssessmentStatusId);

                entity.Property(e => e.UserAssessmentStatusName)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.ModifiedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.DeletedDate)
                      .HasColumnType("datetimeoffset");

                // Only one relationship
                entity.HasMany(e => e.UserAssessments)
                      .WithOne(ua => ua.UserAssessmentStatu)
                      .HasForeignKey(ua => ua.UserAssessmentStatusId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_UserAssessment_UserAssessmentStatu");
        }
    }
}
