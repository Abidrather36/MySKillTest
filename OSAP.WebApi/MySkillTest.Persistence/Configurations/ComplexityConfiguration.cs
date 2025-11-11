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
    public class ComplexityConfiguration: IEntityTypeConfiguration<Complexity>
    {
        public void Configure(EntityTypeBuilder<Complexity> entity)
        {
                entity.HasKey(e => e.ComplexityId);

                entity.Property(e => e.ComplexityLevel)
                    .HasMaxLength(100) // adjust if DB schema specifies a limit
                    .IsRequired();

                entity.HasMany(e => e.AssessmentDetails)
                    .WithOne(ad => ad.Complexity)
                    .HasForeignKey(ad => ad.ComplexityId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.AssessmentDomainLimitTrackers)
                    .WithOne(adlt => adlt.Complexity)
                    .HasForeignKey(adlt => adlt.ComplexityId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.Questions)
                    .WithOne(q => q.Complexity)
                    .HasForeignKey(q => q.ComplexityId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
