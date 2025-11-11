using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class AssessmentConfiguration : IEntityTypeConfiguration<Assessment>
    {
            public void Configure(EntityTypeBuilder<Assessment> entity)
            {
                entity.ToTable("Assessments");

                entity.HasKey(a => a.AssessmentId);

                entity.Property(a => a.AssessmentName)
                      .IsRequired()
                      .HasMaxLength(200);

                // Primary Client
                entity.HasOne(a => a.PrimaryClient)
                      .WithMany(c => c.Assessments) // Client.Assessments
                      .HasForeignKey(a => a.ClientId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Assessment_Client");

                // Secondary Client
                entity.HasOne(a => a.SecondaryClient)
                      .WithMany(c => c.SecondaryAssessments) // Client.SecondaryAssessments
                      .HasForeignKey(a => a.SecondaryClientId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .HasConstraintName("FK_Assessment_Client1");
            }
        }

    }

