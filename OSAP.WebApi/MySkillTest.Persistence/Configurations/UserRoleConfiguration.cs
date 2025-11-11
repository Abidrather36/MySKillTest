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
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> entity)
        {

            entity.ToTable("UserRoles");

            entity.HasKey(e => e.UserRoleId);

            // Relationship: UserMaster
            entity.HasOne(e => e.UserMaster)
                .WithMany()
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Relationship: Client
            entity.HasOne(e => e.Client)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserRole_Client");

            // Relationship: Client1
            entity.HasOne(e => e.Client1)
                .WithMany(c => c.UserRoles1)
                .HasForeignKey(e => e.Client1Id)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserRole_Client1");

            // Relationship: Role
            entity.HasOne(e => e.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserRole_Role");

            // Relationship: Role1
            entity.HasOne(e => e.Role1)
                .WithMany(r => r.UserRoles1)
                .HasForeignKey(e => e.Role1Id)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserRole_Role1");
        }
    }
}
