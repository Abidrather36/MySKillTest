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
    public class UserMasterConfiguration:IEntityTypeConfiguration<UserMaster>
    {
        public void Configure(EntityTypeBuilder<UserMaster> entity)
        {
           
                entity.ToTable("UserMasters");
                entity.HasKey(e => e.UserId);

                // Client Relationship
                entity.HasOne(e => e.Client)
                    .WithMany(c => c.UserMasters)
                    .HasForeignKey(e => e.ClientId)
                    .OnDelete(DeleteBehavior.Restrict);

                // UserAssessment
                entity.HasMany(e => e.UserAssessments)
                    .WithOne(ua => ua.UserMaster)
                    .HasForeignKey(ua => ua.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // UserRoles
                entity.HasMany(e => e.UserRoles)
                    .WithOne(ur => ur.UserMaster)
                    .HasForeignKey(ur => ur.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // UserAssessmentIAI
                entity.HasMany(e => e.UserAssessmentIAIs)
                    .WithOne(ua => ua.UserMaster)
                    .HasForeignKey(ua => ua.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                // UserAssessmentPanels
                entity.HasMany(e => e.UserAssessmentPanels)
                    .WithOne(uap => uap.UserMaster)
                    .HasForeignKey(uap => uap.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
