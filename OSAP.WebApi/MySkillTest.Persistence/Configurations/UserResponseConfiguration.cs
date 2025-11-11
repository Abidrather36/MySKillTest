using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class UserResponseConfiguration : IEntityTypeConfiguration<UserResponse>
    {
        public void Configure(EntityTypeBuilder<UserResponse> entity)
        {

            entity.ToTable("UserResponse");

            entity.HasKey(e => e.UserResponseId);

            entity.Property(e => e.Remarks)
                .HasMaxLength(1000)
                .IsUnicode(true);

            // Answer
            entity.HasOne(e => e.Answer)
                .WithMany(a => a.UserResponses)
                .HasForeignKey(e => e.AnswerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Client
            entity.HasOne(e => e.Client)
                .WithMany(c => c.UserResponses)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question
            entity.HasOne(e => e.Question)
                .WithMany(q => q.UserResponses)
                .HasForeignKey(e => e.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserAssessment
            entity.HasOne(e => e.UserAssessment)
                .WithMany(ua => ua.UserResponses)
                .HasForeignKey(e => e.UserAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Multiple answers (Primary link)
            entity.HasMany(e => e.PrimaryMultipleAnswers)
                .WithOne(ma => ma.PrimaryUserResponse)
                .HasForeignKey(ma => ma.PrimaryUserResponseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Multiple answers (Secondary link)
            entity.HasMany(e => e.SecondaryMultipleAnswers)
                .WithOne(ma => ma.SecondaryUserResponse)
                .HasForeignKey(ma => ma.SecondaryUserResponseId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
