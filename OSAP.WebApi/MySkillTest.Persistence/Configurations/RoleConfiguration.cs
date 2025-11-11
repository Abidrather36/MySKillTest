using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class RoleConfiguration:IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> entity)
        {
            
                entity.ToTable("Role");

                entity.HasKey(e => e.RoleId);

                // Navigation: Client
                entity.HasOne(e => e.Client)
                    .WithMany(c => c.Roles)
                    .HasForeignKey(e => e.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Role_Client");

                // Navigation: Client1
                entity.HasOne(e => e.Client1)
                    .WithMany(c => c.Roles1)
                    .HasForeignKey(e => e.Client1Id)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Role_Client1");

                // Navigation: Client2
                entity.HasOne(e => e.Client2)
                    .WithMany(c => c.Roles2)
                    .HasForeignKey(e => e.Client2Id)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Role_Client2");
        }
    }
}
