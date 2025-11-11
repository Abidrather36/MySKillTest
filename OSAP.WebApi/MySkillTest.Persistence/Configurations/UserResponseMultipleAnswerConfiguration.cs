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
    public class UserResponseMultipleAnswerConfiguration:IEntityTypeConfiguration<UserResponseMultipleAnswer>
    {
        public void Configure(EntityTypeBuilder<UserResponseMultipleAnswer> entity)
        {
                entity.ToTable("UserResponseMultipleAnswer");

                entity.HasKey(e => e.UserResponseAnswerId);

                // Answer link
                entity.HasOne(e => e.Answer)
                    .WithMany(a => a.UserResponseMultipleAnswers)
                    .HasForeignKey(e => e.AnswerId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
