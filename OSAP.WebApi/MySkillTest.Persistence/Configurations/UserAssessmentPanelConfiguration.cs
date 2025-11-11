using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class UserAssessmentPanelConfiguration:IEntityTypeConfiguration<UserAssessmentPanel>
    {
        public void Configure(EntityTypeBuilder<UserAssessmentPanel> entity)
        {
           entity.ToTable("UserAssessmentPanel");

                entity.HasKey(e => e.UserAssessmentPanelId);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.ModifiedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.DeletedDate)
                      .HasColumnType("datetimeoffset");

                // Relationships
                entity.HasOne(e => e.UserAssessment)
                      .WithMany(ua => ua.UserAssessmentPanels)
                      .HasForeignKey(e => e.UserAssessmentId)
                      .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(e => e.UserMaster)
                      .WithMany()
                      .HasForeignKey(e => e.PanelId)
                      .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
