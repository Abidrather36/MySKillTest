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
    public class UserAssessmentTrackerConfiguration:IEntityTypeConfiguration<UserAssessmentTracker>
    {
        public void Configure(EntityTypeBuilder<UserAssessmentTracker> entity)
        {
                entity.HasKey(e => e.UserAssessmentTrackerId);

                // UserAssessment relationship
                entity.HasOne(e => e.UserAssessment)
                    .WithMany(ua => ua.UserAssessmentTrackers)
                    .HasForeignKey(e => e.UserAssessmentId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Domain relationship
                entity.HasOne(e => e.AssessmentDomain)
                    .WithMany(ad => ad.UserAssessmentTrackers)
                    .HasForeignKey(e => e.DomainId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Question relationship (optional)
                entity.HasOne(e => e.Question)
                    .WithMany(q => q.UserAssessmentTrackers)
                    .HasForeignKey(e => e.QuestionId)
                    .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
