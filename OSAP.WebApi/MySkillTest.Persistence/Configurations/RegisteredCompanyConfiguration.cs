using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Domain;

namespace MySkillTest.Persistence.Configurations
{
    public class RegisteredCompanyConfiguration:IEntityTypeConfiguration<RegisteredCompany>
    {
        public void Configure(EntityTypeBuilder<RegisteredCompany> entity)
        {
           
                entity.ToTable("RegisteredCompanies");

                entity.HasKey(e => e.RegisteredCompanyId);

                entity.Property(e => e.CompanyName)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(e => e.EmailAddress)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.Property(e => e.MobileNumber)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(e => e.Country)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(e => e.CreatedBy);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

        }
    }
}
