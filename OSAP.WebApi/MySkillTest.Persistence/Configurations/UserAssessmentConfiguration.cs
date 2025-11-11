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
    public class UserAssessmentConfiguration:IEntityTypeConfiguration<UserAssessment>
    {
        public void Configure(EntityTypeBuilder<UserAssessment> entity)
        {
            entity.ToTable("UserAssessments");

            entity.HasKey(ua => ua.UserAssessmentId);

            entity.Property(ua => ua.ShortUrl)
                  .HasMaxLength(200);

            // Relationships

            // Primary Assessment
            entity.HasOne(ua => ua.PrimaryAssessment)
                  .WithMany(a => a.UserAssessments)
                  .HasForeignKey(ua => ua.AssessmentId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserAssessment_Assessment");

            // Secondary Assessment
            entity.HasOne(ua => ua.SecondaryAssessment)
                  .WithMany(a => a.SecondaryUserAssessments)
                  .HasForeignKey(ua => ua.SecondaryAssessmentId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserAssessment_Assessment1");

            // Primary Client
            entity.HasOne(ua => ua.Client)
                  .WithMany(c => c.UserAssessments)
                  .HasForeignKey(ua => ua.ClientId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserAssessment_Client");

            // Secondary Client
            entity.HasOne(ua => ua.SecondaryClient)
                  .WithMany(c => c.SecondaryUserAssessments)
                  .HasForeignKey(ua => ua.SecondaryClientId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_UserAssessment_Client1");

            // Status
            entity.HasOne(ua => ua.UserAssessmentStatu)
                  .WithMany()
                  .HasForeignKey(ua => ua.UserAssessmentStatusId)
                  .OnDelete(DeleteBehavior.Restrict);

            // User
            entity.HasOne(ua => ua.UserMaster)
                  .WithMany(u => u.UserAssessments)
                  .HasForeignKey(ua => ua.UserId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
