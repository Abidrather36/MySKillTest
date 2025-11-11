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
    public class CompilerConfiguration : IEntityTypeConfiguration<Compiler>
    {
        public void Configure(EntityTypeBuilder<Compiler> entity)
        {

            entity.HasKey(e => e.CompilerId);

            entity.Property(e => e.CompilerName)
                .HasMaxLength(200)
                .IsRequired(false);
            // Configure the relationship from the Compiler side
            entity.HasMany(e => e.AssessmentDomains)
                .WithOne(ad => ad.Compiler)
                .HasForeignKey(ad => ad.CompilerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
