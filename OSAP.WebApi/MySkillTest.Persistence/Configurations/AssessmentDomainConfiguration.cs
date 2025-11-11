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
    public class AssessmentDomainConfiguration:IEntityTypeConfiguration<AssessmentDomain>
    {
        public void Configure(EntityTypeBuilder<AssessmentDomain> entity)
        {
           
                entity.ToTable("AssessmentDomain");

                entity.HasKey(e => e.DomainId);

                entity.Property(e => e.DomainName)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(e => e.DomainShortName)
                      .HasMaxLength(100);

                // Only keep PrimaryDomain relationship here
                entity.HasOne(e => e.PrimaryDomain)
                      .WithMany() // or .WithMany(ad => ad.SubDomains) if self-referencing
                      .HasForeignKey(e => e.PrimaryDomainId)
                      .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
