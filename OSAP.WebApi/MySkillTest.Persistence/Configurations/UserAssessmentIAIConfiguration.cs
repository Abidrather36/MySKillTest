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
    public class UserAssessmentIAIConfiguration:IEntityTypeConfiguration<UserAssessmentIAI>
    {
        public void Configure(EntityTypeBuilder<UserAssessmentIAI> entity)
        {
           
                entity.ToTable("UserAssessmentIAI");

                entity.HasKey(e => e.UserAssessmentIAIId);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

                entity.Property(e => e.ModifiedDate)
                      .HasColumnType("datetimeoffset");

                // Relationships
                entity.HasOne(e => e.UserAssessment)
                      .WithMany(ua => ua.UserAssessmentIAIs)
                      .HasForeignKey(e => e.UserAssessmentId)
                      .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(e => e.UserMaster)
                      .WithMany()
                      .HasForeignKey(e => e.UserId)
                      .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
