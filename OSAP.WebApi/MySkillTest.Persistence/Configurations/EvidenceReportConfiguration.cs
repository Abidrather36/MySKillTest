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
    public class EvidenceReportConfiguration:IEntityTypeConfiguration<EvidenceReport>
    {
        public void Configure(EntityTypeBuilder<EvidenceReport> entity)
        {
                entity.HasKey(e => e.EvidenceReportId);

                entity.Property(e => e.Screen_recording_url)
                    .HasColumnName("Screen_recording_url");

                entity.Property(e => e.Test_taker_photo_url)
                    .HasColumnName("Test_taker_photo_url");

                entity.HasOne(e => e.UserAssessment)
                    .WithMany(ua => ua.EvidenceReports)
                    .HasForeignKey(e => e.UserAssessmentId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
