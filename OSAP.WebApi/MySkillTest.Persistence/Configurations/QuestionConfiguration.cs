using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    internal class QuestionConfiguration:IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> entity)
        {
          
                entity.HasKey(q => q.QuestionId);

                entity.Property(q => q.QuestionText)
                    .IsRequired()
                    .HasMaxLength(2000); // Adjust if needed

                entity.Property(q => q.QuestionTextFormatted)
                    .HasMaxLength(4000);

                entity.HasOne(q => q.AssessmentDomain)
                    .WithMany(ad => ad.Questions)
                    .HasForeignKey(q => q.DomainId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(q => q.Complexity)
                    .WithMany(c => c.Questions)
                    .HasForeignKey(q => q.ComplexityId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(q => q.QuestionType)
                    .WithMany(qt => qt.Questions)
                    .HasForeignKey(q => q.QuestionTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
