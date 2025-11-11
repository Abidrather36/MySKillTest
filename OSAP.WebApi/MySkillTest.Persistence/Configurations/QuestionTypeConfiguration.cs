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
    public class QuestionTypeConfiguration:IEntityTypeConfiguration<QuestionType>
    {
        public void Configure(EntityTypeBuilder<QuestionType> entity)
        {
          
                entity.ToTable("QuestionType");

                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeDescription)
                      .HasMaxLength(255);

                entity.Property(e => e.MultipleChoice);
                entity.Property(e => e.Coding);
                entity.Property(e => e.AllowMultipleSelection);

                entity.Property(e => e.CreatedBy);

                entity.Property(e => e.CreatedDate)
                      .HasColumnType("datetimeoffset");

                entity.HasMany(e => e.Questions)
                      .WithOne(q => q.QuestionType)
                      .HasForeignKey(q => q.QuestionTypeId)
                      .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
