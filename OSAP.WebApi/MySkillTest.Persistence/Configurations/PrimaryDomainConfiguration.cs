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
    public class PrimaryDomainConfiguration:IEntityTypeConfiguration<PrimaryDomain>
    {
        public void Configure(EntityTypeBuilder<PrimaryDomain> entity)
        {
            
                entity.HasKey(pd => pd.PrimaryDomainId);

                entity.Property(pd => pd.PrimaryDomainName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(pd => pd.PrimaryDomainShortName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasMany(pd => pd.AssessmentDomains)
                    .WithOne(ad => ad.PrimaryDomain)
                    .HasForeignKey(ad => ad.PrimaryDomainId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
