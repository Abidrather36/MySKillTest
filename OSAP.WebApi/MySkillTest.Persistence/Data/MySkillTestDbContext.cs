using Microsoft.EntityFrameworkCore;
using MySkillTest.Domain.Domain;
using MySkillTest.Domain.Entities;
using MySkillTest.Persistence.Configurations;

namespace MySkillTest.Persistence.Data
{
    public class MySkillTestDbContext : DbContext
    {
        public MySkillTestDbContext(DbContextOptions<MySkillTestDbContext> options) : base(options)
        {
            
        }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Assessment> Assessments { get; set; }
        public virtual DbSet<AssessmentDetail> AssessmentDetails { get; set; }
        public virtual DbSet<AssessmentDomain> AssessmentDomains { get; set; }
        public virtual DbSet<AssessmentDomainLimitTracker> AssessmentDomainLimitTrackers { get; set; }
        public virtual DbSet<AssessmentLibrary> AssessmentLibraries { get; set; }
        public virtual DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Complexity> Complexities { get; set; }
        public virtual DbSet<LibraryQuestion> LibraryQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserAssessment> UserAssessments { get; set; }
        public virtual DbSet<UserAssessmentStatu> UserAssessmentStatus { get; set; }
        public virtual DbSet<UserAssessmentTracker> UserAssessmentTrackers { get; set; }
        public virtual DbSet<UserMaster> UserMasters { get; set; }
        public virtual DbSet<UserResponse> UserResponses { get; set; }
        public virtual DbSet<UserResponseFreeTextAnswer> UserResponseFreeTextAnswers { get; set; }
        public virtual DbSet<UserResponseMultipleAnswer> UserResponseMultipleAnswers { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserAssessmentIAI> UserAssessmentIAIs { get; set; }
        public virtual DbSet<Compiler> Compilers { get; set; }
        public virtual DbSet<EvidenceReport> EvidenceReports { get; set; }
        public virtual DbSet<EvidenceReportDetail> EvidenceReportDetails { get; set; }
        public virtual DbSet<RegisteredCompany> RegisteredCompanies { get; set; }
        public virtual DbSet<UserAssessmentEvidenceDetail> UserAssessmentEvidenceDetails { get; set; }
        public virtual DbSet<UserAssessmentFile> UserAssessmentFiles { get; set; }
        public virtual DbSet<PrimaryDomain> PrimaryDomains { get; set; }
        public virtual DbSet<ProctoringResult> ProctoringResults { get; set; }
        public virtual DbSet<UserAssessmentProctorResult> UserAssessmentProctorResults { get; set; }
        public virtual DbSet<UserAssessmentPanel> UserAssessmentPanels { get; set; }
        public virtual DbSet<ClientLogo> ClientLogoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySkillTestDbContext).Assembly);
            // Assessment → Client mappings
        //    modelBuilder.Entity<Assessment>()
        //        .HasOne(a => a.Client)
        //        .WithMany(c => c.Assessments)
        //        .HasForeignKey(a => a.ClientId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Assessment>()
        //        .HasOne(a => a.Client1)
        //        .WithMany(c => c.Assessments1)
        //        .HasForeignKey(a => a.SecondaryClientId)
        //        .OnDelete(DeleteBehavior.Restrict);

        //    modelBuilder.Entity<Compiler>(entity =>
        //    {
        //        entity.HasKey(e => e.CompilerId);

        //        entity.Property(e => e.CompilerName)
        //            .HasMaxLength(200)
        //            .IsRequired(false);

        //        // Configure the relationship from the Compiler side
        //        entity.HasMany(e => e.AssessmentDomains)
        //            .WithOne(ad => ad.Compiler)
        //            .HasForeignKey(ad => ad.CompilerId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });

        //    modelBuilder.Entity<Complexity>(entity =>
        //        {
        //            entity.HasKey(e => e.ComplexityId);

        //            entity.Property(e => e.ComplexityLevel)
        //                .HasMaxLength(100) // adjust if DB schema specifies a limit
        //                .IsRequired();

        //            entity.HasMany(e => e.AssessmentDetails)
        //                .WithOne(ad => ad.Complexity)
        //                .HasForeignKey(ad => ad.ComplexityId)
        //                .OnDelete(DeleteBehavior.Restrict);

        //            entity.HasMany(e => e.AssessmentDomainLimitTrackers)
        //                .WithOne(adlt => adlt.Complexity)
        //                .HasForeignKey(adlt => adlt.ComplexityId)
        //                .OnDelete(DeleteBehavior.Restrict);

        //            entity.HasMany(e => e.Questions)
        //                .WithOne(q => q.Complexity)
        //                .HasForeignKey(q => q.ComplexityId)
        //                .OnDelete(DeleteBehavior.Restrict);
        //        });
        //    modelBuilder.Entity<EvidenceReport>(entity =>
        //    {
        //        entity.HasKey(e => e.EvidenceReportId);

        //        entity.Property(e => e.Screen_recording_url)
        //            .HasColumnName("Screen_recording_url");

        //        entity.Property(e => e.Test_taker_photo_url)
        //            .HasColumnName("Test_taker_photo_url");

        //        entity.HasOne(e => e.UserAssessment)
        //            .WithMany(ua => ua.EvidenceReports)
        //            .HasForeignKey(e => e.UserAssessmentId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });
        //    modelBuilder.Entity<EvidenceReportDetail>(entity =>
        //    {
        //        entity.HasKey(e => e.EvidenceReportDetailId);

        //        entity.Property(e => e.Evidence_label)
        //            .HasColumnName("Evidence_label");

        //        entity.Property(e => e.Evidence_iso_datetime)
        //            .HasColumnName("Evidence_iso_datetime");

        //        entity.Property(e => e.Is_violation)
        //            .HasColumnName("Is_violation");

        //        entity.Property(e => e.Evidence_url)
        //            .HasColumnName("Evidence_url");

        //        entity.HasOne(e => e.EvidenceReport)
        //            .WithMany(er => er.EvidenceReportDetails)
        //            .HasForeignKey(e => e.EvidenceReportId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });
        //    modelBuilder.Entity<LibraryQuestion>(entity =>
        //    {
        //        entity.HasKey(lq => lq.LibraryQuestionId);

        //        entity.HasOne(lq => lq.Assessment)
        //            .WithMany(a => a.LibraryQuestions)
        //            .HasForeignKey(lq => lq.AssessmentId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(lq => lq.Question)
        //            .WithMany(q => q.LibraryQuestions)
        //            .HasForeignKey(lq => lq.QuestionId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });
        //    modelBuilder.Entity<PrimaryDomain>(entity =>
        //    {
        //        entity.HasKey(pd => pd.PrimaryDomainId);

        //        entity.Property(pd => pd.PrimaryDomainName)
        //            .IsRequired()
        //            .HasMaxLength(255);

        //        entity.Property(pd => pd.PrimaryDomainShortName)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        entity.HasMany(pd => pd.AssessmentDomains)
        //            .WithOne(ad => ad.PrimaryDomain)
        //            .HasForeignKey(ad => ad.PrimaryDomainId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });


        //    modelBuilder.Entity<Question>(entity =>
        //    {
        //        entity.HasKey(q => q.QuestionId);

        //        entity.Property(q => q.QuestionText)
        //            .IsRequired()
        //            .HasMaxLength(2000); // Adjust if needed

        //        entity.Property(q => q.QuestionTextFormatted)
        //            .HasMaxLength(4000);

        //        entity.HasOne(q => q.AssessmentDomain)
        //            .WithMany(ad => ad.Questions)
        //            .HasForeignKey(q => q.DomainId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(q => q.Complexity)
        //            .WithMany(c => c.Questions)
        //            .HasForeignKey(q => q.ComplexityId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        entity.HasOne(q => q.QuestionType)
        //            .WithMany(qt => qt.Questions)
        //            .HasForeignKey(q => q.QuestionTypeId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });

        //    modelBuilder.Entity<QuestionType>(entity =>
        //    {
        //        entity.ToTable("QuestionType");

        //        entity.HasKey(e => e.TypeId);

        //        entity.Property(e => e.TypeDescription)
        //              .HasMaxLength(255);

        //        entity.Property(e => e.MultipleChoice);
        //        entity.Property(e => e.Coding);
        //        entity.Property(e => e.AllowMultipleSelection);

        //        entity.Property(e => e.CreatedBy);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.HasMany(e => e.Questions)
        //              .WithOne(q => q.QuestionType)
        //              .HasForeignKey(q => q.QuestionTypeId)
        //              .OnDelete(DeleteBehavior.Cascade);
        //    });
        //    modelBuilder.Entity<RegisteredCompany>(entity =>
        //    {
        //        entity.ToTable("RegisteredCompanies");

        //        entity.HasKey(e => e.RegisteredCompanyId);

        //        entity.Property(e => e.CompanyName)
        //              .IsRequired()
        //              .HasMaxLength(200);

        //        entity.Property(e => e.EmailAddress)
        //              .IsRequired()
        //              .HasMaxLength(255);

        //        entity.Property(e => e.MobileNumber)
        //              .IsRequired()
        //              .HasMaxLength(20);

        //        entity.Property(e => e.Country)
        //              .IsRequired()
        //              .HasMaxLength(100);

        //        entity.Property(e => e.CreatedBy);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");
        //    });
        //    modelBuilder.Entity<Role>(entity =>
        //    {
        //        entity.ToTable("Role");

        //        entity.HasKey(e => e.RoleId);

        //        // Navigation: Client
        //        entity.HasOne(e => e.Client)
        //        .WithMany(c => c.Roles)
        //        .HasForeignKey(e => e.ClientId)
        //        .OnDelete(DeleteBehavior.Restrict)
        //        .HasConstraintName("FK_Role_Client");

        //    // Navigation: Client1
        //    entity.HasOne(e => e.Client1)
        //        .WithMany(c => c.Roles1)
        //        .HasForeignKey(e => e.Client1Id)
        //        .OnDelete(DeleteBehavior.Restrict)
        //        .HasConstraintName("FK_Role_Client1");

        //    // Navigation: Client2
        //    entity.HasOne(e => e.Client2)
        //        .WithMany(c => c.Roles2)
        //        .HasForeignKey(e => e.Client2Id)
        //        .OnDelete(DeleteBehavior.Restrict)
        //        .HasConstraintName("FK_Role_Client2");
        //});

        //    modelBuilder.Entity<UserAssessment>(entity =>
        //        {
        //            entity.ToTable("UserAssessment");

        //            entity.HasKey(e => e.UserAssessmentId);

        //            entity.Property(e => e.ShortUrl)
        //                  .HasMaxLength(500);

        //            entity.Property(e => e.CreatedDate)
        //                  .HasColumnType("datetimeoffset");

        //            entity.Property(e => e.StatusUpdateDateTime)
        //                  .HasColumnType("datetimeoffset");

        //            entity.Property(e => e.ModifiedDate)
        //                  .HasColumnType("datetimeoffset");

        //            entity.Property(e => e.DeletedDate)
        //                  .HasColumnType("datetimeoffset");

        //            // Client (primary)
        //            entity.HasOne(ua => ua.Client)
        //                  .WithMany(c => c.UserAssessments)
        //                  .HasForeignKey(ua => ua.ClientId)
        //                  .OnDelete(DeleteBehavior.Restrict)
        //                  .HasConstraintName("FK_UserAssessment_Client");

        //            // Client1 (secondary)
        //            entity.HasOne(ua => ua.Client1)
        //                  .WithMany(c => c.UserAssessments1)
        //                  .HasForeignKey(ua => ua.SecondaryClientId)
        //                  .OnDelete(DeleteBehavior.Restrict)
        //                  .HasConstraintName("FK_UserAssessment_Client1");

        //            // Assessment
        //            entity.HasOne(ua => ua.Assessment)
        //                  .WithMany(a => a.UserAssessments)
        //                  .HasForeignKey(ua => ua.AssessmentId)
        //                  .OnDelete(DeleteBehavior.Restrict)
        //                  .HasConstraintName("FK_UserAssessment_Assessment");

        //            // If Assessment1 is valid (with separate FK), map it properly — otherwise remove this
        //            // entity.HasOne(ua => ua.Assessment1)
        //            //       .WithMany(a => a.UserAssessments1)
        //            //       .HasForeignKey(ua => ua.Assessment1Id)
        //            //       .OnDelete(DeleteBehavior.Restrict)
        //            //       .HasConstraintName("FK_UserAssessment_Assessment1");

        //            // UserAssessment Status
        //            entity.HasOne(e => e.UserAssessmentStatu)
        //                  .WithMany()
        //                  .HasForeignKey(e => e.UserAssessmentStatusId)
        //                  .OnDelete(DeleteBehavior.Restrict);

        //            // UserMaster
        //            entity.HasOne(e => e.UserMaster)
        //                  .WithMany()
        //                  .HasForeignKey(e => e.UserId)
        //                  .OnDelete(DeleteBehavior.Restrict);
        //        });

        //    modelBuilder.Entity<UserAssessmentEvidenceDetail>(entity =>
        //    {
        //        entity.ToTable("UserAssessmentEvidenceDetail");

        //        entity.HasKey(e => e.UserAssessmentEvidenceId);

        //        entity.Property(e => e.TestAttemptId)
        //              .IsRequired()
        //              .HasMaxLength(100);

        //        entity.Property(e => e.HashedTestAttemptId)
        //              .IsRequired()
        //              .HasMaxLength(256);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.ModifiedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.HasOne(e => e.UserAssessment)
        //              .WithMany(ua => ua.UserAssessmentEvidenceDetails)
        //              .HasForeignKey(e => e.UserAssessmentId)
        //              .OnDelete(DeleteBehavior.Cascade);
        //    });
        //    modelBuilder.Entity<UserAssessmentIAI>(entity =>
        //    {
        //        entity.ToTable("UserAssessmentIAI");

        //        entity.HasKey(e => e.UserAssessmentIAIId);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.ModifiedDate)
        //              .HasColumnType("datetimeoffset");

        //        // Relationships
        //        entity.HasOne(e => e.UserAssessment)
        //              .WithMany(ua => ua.UserAssessmentIAIs)
        //              .HasForeignKey(e => e.UserAssessmentId)
        //              .OnDelete(DeleteBehavior.NoAction);

        //        entity.HasOne(e => e.UserMaster)
        //              .WithMany()
        //              .HasForeignKey(e => e.UserId)
        //              .OnDelete(DeleteBehavior.NoAction);
        //    });
        //    modelBuilder.Entity<UserAssessmentPanel>(entity =>
        //    {
        //        entity.ToTable("UserAssessmentPanel");

        //        entity.HasKey(e => e.UserAssessmentPanelId);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.ModifiedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.DeletedDate)
        //              .HasColumnType("datetimeoffset");

        //        // Relationships
        //        entity.HasOne(e => e.UserAssessment)
        //              .WithMany(ua => ua.UserAssessmentPanels)
        //              .HasForeignKey(e => e.UserAssessmentId)
        //              .OnDelete(DeleteBehavior.Cascade);

        //        entity.HasOne(e => e.UserMaster)
        //              .WithMany()
        //              .HasForeignKey(e => e.PanelId)
        //              .OnDelete(DeleteBehavior.NoAction);
        //    });
        //    modelBuilder.Entity<UserAssessmentStatu>(entity =>
        //    {
        //        entity.ToTable("UserAssessmentStatu");

        //        entity.HasKey(e => e.UserAssessmentStatusId);

        //        entity.Property(e => e.UserAssessmentStatusName)
        //              .IsRequired()
        //              .HasMaxLength(200);

        //        entity.Property(e => e.CreatedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.ModifiedDate)
        //              .HasColumnType("datetimeoffset");

        //        entity.Property(e => e.DeletedDate)
        //              .HasColumnType("datetimeoffset");

        //        // Only one relationship
        //        entity.HasMany(e => e.UserAssessments)
        //              .WithOne(ua => ua.UserAssessmentStatu)
        //              .HasForeignKey(ua => ua.UserAssessmentStatusId)
        //              .OnDelete(DeleteBehavior.Restrict)
        //              .HasConstraintName("FK_UserAssessment_UserAssessmentStatu");
        //    });

        //    modelBuilder.Entity<UserAssessmentTracker>(entity =>
        //    {
        //        entity.HasKey(e => e.UserAssessmentTrackerId);

        //        // UserAssessment relationship
        //        entity.HasOne(e => e.UserAssessment)
        //            .WithMany(ua => ua.UserAssessmentTrackers)
        //            .HasForeignKey(e => e.UserAssessmentId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // Domain relationship
        //        entity.HasOne(e => e.AssessmentDomain)
        //            .WithMany(ad => ad.UserAssessmentTrackers)
        //            .HasForeignKey(e => e.DomainId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        // Question relationship (optional)
        //        entity.HasOne(e => e.Question)
        //            .WithMany(q => q.UserAssessmentTrackers)
        //            .HasForeignKey(e => e.QuestionId)
        //            .OnDelete(DeleteBehavior.SetNull);
        //    });
        //    modelBuilder.Entity<UserMaster>(entity =>
        //    {
        //        entity.ToTable("UserMasters");
        //        entity.HasKey(e => e.UserId);

        //        // Client Relationship
        //        entity.HasOne(e => e.Client)
        //            .WithMany(c => c.UserMasters)
        //            .HasForeignKey(e => e.ClientId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        // UserAssessment
        //        entity.HasMany(e => e.UserAssessments)
        //            .WithOne(ua => ua.UserMaster)
        //            .HasForeignKey(ua => ua.UserId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // UserRoles
        //        entity.HasMany(e => e.UserRoles)
        //            .WithOne(ur => ur.UserMaster)
        //            .HasForeignKey(ur => ur.UserId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // UserAssessmentIAI
        //        entity.HasMany(e => e.UserAssessmentIAIs)
        //            .WithOne(ua => ua.UserMaster)
        //            .HasForeignKey(ua => ua.UserId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // UserAssessmentPanels
        //        entity.HasMany(e => e.UserAssessmentPanels)
        //            .WithOne(uap => uap.UserMaster)
        //            .HasForeignKey(uap => uap.UserId)
        //            .OnDelete(DeleteBehavior.Cascade);
        //    });

        //    modelBuilder.Entity<UserResponse>(entity =>
        //    {
        //        entity.ToTable("UserResponse");

        //        entity.HasKey(e => e.UserResponseId);

        //        entity.Property(e => e.Remarks)
        //            .HasMaxLength(1000)
        //            .IsUnicode(true);

        //        // Answer
        //        entity.HasOne(e => e.Answer)
        //            .WithMany(a => a.UserResponses)
        //            .HasForeignKey(e => e.AnswerId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        // Client
        //        entity.HasOne(e => e.Client)
        //            .WithMany(c => c.UserResponses)
        //            .HasForeignKey(e => e.ClientId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        // Question
        //        entity.HasOne(e => e.Question)
        //            .WithMany(q => q.UserResponses)
        //            .HasForeignKey(e => e.QuestionId)
        //            .OnDelete(DeleteBehavior.Restrict);

        //        // UserAssessment
        //        entity.HasOne(e => e.UserAssessment)
        //            .WithMany(ua => ua.UserResponses)
        //            .HasForeignKey(e => e.UserAssessmentId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // Multiple answers (Primary link)
        //        entity.HasMany(e => e.PrimaryMultipleAnswers)
        //            .WithOne(ma => ma.PrimaryUserResponse)
        //            .HasForeignKey(ma => ma.PrimaryUserResponseId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // Multiple answers (Secondary link)
        //        entity.HasMany(e => e.SecondaryMultipleAnswers)
        //            .WithOne(ma => ma.SecondaryUserResponse)
        //            .HasForeignKey(ma => ma.SecondaryUserResponseId)
        //            .OnDelete(DeleteBehavior.Cascade);
        //    });

        //    modelBuilder.Entity<UserResponseMultipleAnswer>(entity =>
        //    {
        //        entity.ToTable("UserResponseMultipleAnswer");

        //        entity.HasKey(e => e.UserResponseAnswerId);

        //        // Answer link
        //        entity.HasOne(e => e.Answer)
        //            .WithMany(a => a.UserResponseMultipleAnswers)
        //            .HasForeignKey(e => e.AnswerId)
        //            .OnDelete(DeleteBehavior.Restrict);
        //    });
        //    modelBuilder.Entity<UserRole>(entity =>
        //    {
        //        entity.ToTable("UserRole");

        //        entity.HasKey(e => e.UserRoleId);

        //        // Relationship: UserMaster
        //        entity.HasOne(e => e.UserMaster)
        //            .WithMany()
        //            .HasForeignKey(e => e.UserId)
        //            .OnDelete(DeleteBehavior.Cascade);

        //        // Relationship: Client
        //        entity.HasOne(e => e.Client)
        //            .WithMany(c => c.UserRoles)
        //            .HasForeignKey(e => e.ClientId)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UserRole_Client");

        //        // Relationship: Client1
        //        entity.HasOne(e => e.Client1)
        //            .WithMany(c => c.UserRoles1)
        //            .HasForeignKey(e => e.Client1Id)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UserRole_Client1");

        //        // Relationship: Role
        //        entity.HasOne(e => e.Role)
        //            .WithMany(r => r.UserRoles)
        //            .HasForeignKey(e => e.RoleId)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UserRole_Role");

        //        // Relationship: Role1
        //        entity.HasOne(e => e.Role1)
        //            .WithMany(r => r.UserRoles1)
        //            .HasForeignKey(e => e.Role1Id)
        //            .OnDelete(DeleteBehavior.Restrict)
        //            .HasConstraintName("FK_UserRole_Role1");
        //    });


        //    modelBuilder.Entity<AssessmentDomain>(entity =>
        //    {
        //        entity.ToTable("AssessmentDomain");

        //        entity.HasKey(e => e.DomainId);

        //        entity.Property(e => e.DomainName)
        //              .IsRequired()
        //              .HasMaxLength(200);

        //        entity.Property(e => e.DomainShortName)
        //              .HasMaxLength(100);

        //        // Only keep PrimaryDomain relationship here
        //        entity.HasOne(e => e.PrimaryDomain)
        //              .WithMany() // or .WithMany(ad => ad.SubDomains) if self-referencing
        //              .HasForeignKey(e => e.PrimaryDomainId)
        //              .OnDelete(DeleteBehavior.Restrict);
        //    });
        //    modelBuilder.Entity<AssessmentLibrary>(entity =>
        //        {
        //            entity.ToTable("AssessmentLibrary");

        //            entity.HasKey(e => e.LibraryId); // ✅ This defines the PK

        //            entity.Property(e => e.LibraryName)
        //                  .IsRequired()
        //                  .HasMaxLength(200); // Adjust length if needed

        //            entity.Property(e => e.DomainId)
        //                  .IsRequired();

        //            entity.HasOne(e => e.AssessmentDomain)
        //                  .WithMany(ad => ad.AssessmentLibraries)
        //                  .HasForeignKey(e => e.DomainId)
        //                  .OnDelete(DeleteBehavior.Restrict)
        //                  .HasConstraintName("FK_AssessmentLibrary_AssessmentDomain");

        //            entity.Property(e => e.CreatedDate).HasColumnType("datetimeoffset");
        //            entity.Property(e => e.ModifiedDate).HasColumnType("datetimeoffset");
        //            entity.Property(e => e.DeletedDate).HasColumnType("datetimeoffset");
        //        });




        }
    }
}
