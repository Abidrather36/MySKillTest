using Microsoft.EntityFrameworkCore;
using MySkillTest.Domain.Domain;
using MySkillTest.Domain.Entities;

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

    }
}
