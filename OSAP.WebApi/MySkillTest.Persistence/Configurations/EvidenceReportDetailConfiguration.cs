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
    public class EvidenceReportDetailConfiguration:IEntityTypeConfiguration<EvidenceReportDetail>
    {
        public void Configure(EntityTypeBuilder<EvidenceReportDetail> entity)
        {
            entity.HasKey(e => e.EvidenceReportDetailId);

            entity.Property(e => e.Evidence_label)
                .HasColumnName("Evidence_label");

            entity.Property(e => e.Evidence_iso_datetime)
                .HasColumnName("Evidence_iso_datetime");

            entity.Property(e => e.Is_violation)
                .HasColumnName("Is_violation");

            entity.Property(e => e.Evidence_url)
                .HasColumnName("Evidence_url");

            entity.HasOne(e => e.EvidenceReport)
                .WithMany(er => er.EvidenceReportDetails)
                .HasForeignKey(e => e.EvidenceReportId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
