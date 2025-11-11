using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySkillTest.Domain.Entities;

namespace MySkillTest.Persistence.Configurations
{
    public class AssessmentLibraryConfiguration : IEntityTypeConfiguration<AssessmentLibrary>
    {
        public void Configure(EntityTypeBuilder<AssessmentLibrary> entity)
        {

            entity.ToTable("AssessmentLibrary");

            entity.HasKey(e => e.LibraryId); // ✅ This defines the PK

            entity.Property(e => e.LibraryName)
                  .IsRequired()
                  .HasMaxLength(200); // Adjust length if needed

            entity.Property(e => e.DomainId)
                  .IsRequired();

            entity.HasOne(e => e.AssessmentDomain)
                  .WithMany(ad => ad.AssessmentLibraries)
                  .HasForeignKey(e => e.DomainId)
                  .OnDelete(DeleteBehavior.Restrict)
                  .HasConstraintName("FK_AssessmentLibrary_AssessmentDomain");

            entity.Property(e => e.CreatedDate).HasColumnType("datetimeoffset");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetimeoffset");
            entity.Property(e => e.DeletedDate).HasColumnType("datetimeoffset");
        }
    }
}
