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
    public class LibraryQuestionConfiguration:IEntityTypeConfiguration<LibraryQuestion>
    {
        public void Configure(EntityTypeBuilder<LibraryQuestion> entity)
        {
            
                entity.HasKey(lq => lq.LibraryQuestionId);

                entity.HasOne(lq => lq.Assessment)
                    .WithMany(a => a.LibraryQuestions)
                    .HasForeignKey(lq => lq.AssessmentId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(lq => lq.Question)
                    .WithMany(q => q.LibraryQuestions)
                    .HasForeignKey(lq => lq.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
