using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entity)
        {
            entity.ToTable("Clients");

            entity.HasKey(e => e.ClientId);

            entity.Property(e => e.ClientName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ClientConfigurationJson)
                .IsRequired(false);

            entity.Property(e => e.ApplicationUri)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.LoweredApplicationUri)
                .IsRequired()
                .HasMaxLength(500);

            // Relationships

            // Client → UserMasters (1-to-many)
            entity.HasMany(c => c.UserMasters)
                  .WithOne(u => u.Client)
                  .HasForeignKey(u => u.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);

            // Client → UserRoles (1-to-many)
            entity.HasMany(c => c.UserRoles)
                  .WithOne(ur => ur.Client)
                  .HasForeignKey(ur => ur.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);

            // Client → UserRoles1 (legacy relationship)
            entity.HasMany(c => c.UserRoles1)
                  .WithOne(ur => ur.Client1)
                  .HasForeignKey(ur => ur.Client1Id)
                  .OnDelete(DeleteBehavior.Restrict);

            // Client → Roles
            entity.HasMany(c => c.Roles)
                  .WithOne(r => r.Client)
                  .HasForeignKey(r => r.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(c => c.Roles1)
                  .WithOne(r => r.Client1)
                  .HasForeignKey(r => r.Client1Id)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(c => c.Roles2)
                  .WithOne(r => r.Client2)
                  .HasForeignKey(r => r.Client2Id)
                  .OnDelete(DeleteBehavior.Restrict);

            // Client → Assessments
            // Client → Primary Assessments
            // Client → Primary Assessments
            entity.HasMany(c => c.Assessments)
                  .WithOne(a => a.PrimaryClient)
                  .HasForeignKey(a => a.ClientId)
                  .OnDelete(DeleteBehavior.NoAction) // or Restrict
                  .HasConstraintName("FK_Assessment_Client");

            // Client → Secondary Assessments
            entity.HasMany(c => c.SecondaryAssessments)
                  .WithOne(a => a.SecondaryClient)
                  .HasForeignKey(a => a.SecondaryClientId)
                  .OnDelete(DeleteBehavior.NoAction)
                  .HasConstraintName("FK_Assessment_Client1");



            // Client → UserAssessments (primary client)
            entity.HasMany(c => c.UserAssessments)
                  .WithOne(ua => ua.Client)
                  .HasForeignKey(ua => ua.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);

            // Client → SecondaryUserAssessments (secondary client)
            entity.HasMany(c => c.SecondaryUserAssessments)
                  .WithOne(ua => ua.SecondaryClient)
                  .HasForeignKey(ua => ua.SecondaryClientId)
                  .OnDelete(DeleteBehavior.Restrict);


            // Client → UserResponses
            entity.HasMany(c => c.UserResponses)
                  .WithOne(ur => ur.Client)
                  .HasForeignKey(ur => ur.ClientId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
