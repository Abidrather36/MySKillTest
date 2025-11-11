using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySkillTest.Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientLogoes",
                columns: table => new
                {
                    ClientLogoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientLogoGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientLogoContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLogoes", x => x.ClientLogoId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientConfigurationJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUri = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LoweredApplicationUri = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Compilers",
                columns: table => new
                {
                    CompilerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompilerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CompilerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonacoEditorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compilers", x => x.CompilerId);
                });

            migrationBuilder.CreateTable(
                name: "Complexities",
                columns: table => new
                {
                    ComplexityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplexityLevel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complexities", x => x.ComplexityId);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryDomains",
                columns: table => new
                {
                    PrimaryDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryDomainName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PrimaryDomainShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryDomains", x => x.PrimaryDomainId);
                });

            migrationBuilder.CreateTable(
                name: "ProctoringResults",
                columns: table => new
                {
                    ProctoringResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RawContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoppedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SignedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesB1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesB2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesB3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesC1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesC2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesC3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesC4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesC5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesK1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesM1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesM2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesN1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesN2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesS1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AveragesS2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProctoringResults", x => x.ProctoringResultId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    TypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MultipleChoice = table.Column<bool>(type: "bit", nullable: true),
                    Coding = table.Column<bool>(type: "bit", nullable: true),
                    AllowMultipleSelection = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionType", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredCompanies",
                columns: table => new
                {
                    RegisteredCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredCompanies", x => x.RegisteredCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentFiles",
                columns: table => new
                {
                    UserAssessmentFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentFiles", x => x.UserAssessmentFileId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentProctorResults",
                columns: table => new
                {
                    UserAssessmentProctorResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResultContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDFContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentProctorResults", x => x.UserAssessmentProctorResultId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentStatu",
                columns: table => new
                {
                    UserAssessmentStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentStatu", x => x.UserAssessmentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "UserResponseFreeTextAnswers",
                columns: table => new
                {
                    UserResponseFreeTextAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnswerCompiled = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponseFreeTextAnswers", x => x.UserResponseFreeTextAnswerId);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondaryClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssessmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TimeLimitInMinutes = table.Column<int>(type: "int", nullable: false),
                    AttemptsAllowed = table.Column<int>(type: "int", nullable: true),
                    AllowPausing = table.Column<bool>(type: "bit", nullable: true),
                    RandomizeQuestions = table.Column<bool>(type: "bit", nullable: true),
                    ReadQuestionsFromAssessment = table.Column<bool>(type: "bit", nullable: true),
                    IsFreezed = table.Column<bool>(type: "bit", nullable: true),
                    IsProctorRequired = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "FK_Assessment_Client",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Assessment_Client1",
                        column: x => x.SecondaryClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Client1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Client2Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoweredRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Role_Client",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_Client1",
                        column: x => x.Client1Id,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_Client2",
                        column: x => x.Client2Id,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserMasters",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoweredUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastActivityDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordFormat = table.Column<int>(type: "int", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastPasswordChangedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastLockoutDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FailedPasswordAttemptCount = table.Column<int>(type: "int", nullable: true),
                    PasswordResetRequestActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMasters", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserMasters_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDomain",
                columns: table => new
                {
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DomainShortName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompilerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrimaryDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDomain", x => x.DomainId);
                    table.ForeignKey(
                        name: "FK_AssessmentDomain_Compilers_CompilerId",
                        column: x => x.CompilerId,
                        principalTable: "Compilers",
                        principalColumn: "CompilerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentDomain_PrimaryDomains_PrimaryDomainId",
                        column: x => x.PrimaryDomainId,
                        principalTable: "PrimaryDomains",
                        principalColumn: "PrimaryDomainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessments",
                columns: table => new
                {
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondaryAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserAssessmentStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecondaryClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StartDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    EndDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TimeRemainingInMinutes = table.Column<int>(type: "int", nullable: true),
                    Attempts = table.Column<int>(type: "int", nullable: true),
                    ShortUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RunningScore = table.Column<int>(type: "int", nullable: true),
                    TotalScore = table.Column<int>(type: "int", nullable: true),
                    StatusUpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    StatusUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessments", x => x.UserAssessmentId);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Assessment",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Assessment1",
                        column: x => x.SecondaryAssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Client",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Client1",
                        column: x => x.SecondaryClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessment_UserAssessmentStatu",
                        column: x => x.UserAssessmentStatusId,
                        principalTable: "UserAssessmentStatu",
                        principalColumn: "UserAssessmentStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessments_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Client1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserMasterUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRole_Client",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_Client1",
                        column: x => x.Client1Id,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_Role1",
                        column: x => x.Role1Id,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserMasters_UserMasterUserId",
                        column: x => x.UserMasterUserId,
                        principalTable: "UserMasters",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDetails",
                columns: table => new
                {
                    AssessmentDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplexityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoOfQuestions = table.Column<int>(type: "int", nullable: false),
                    NoOfCodingQuestions = table.Column<int>(type: "int", nullable: false),
                    TimeLimitInMinutes = table.Column<int>(type: "int", nullable: true),
                    AssessmentDomainDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDetails", x => x.AssessmentDetailId);
                    table.ForeignKey(
                        name: "FK_AssessmentDetails_AssessmentDomain_AssessmentDomainDomainId",
                        column: x => x.AssessmentDomainDomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentDetails_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentDetails_Complexities_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexities",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentLibrary",
                columns: table => new
                {
                    LibraryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentLibrary", x => x.LibraryId);
                    table.ForeignKey(
                        name: "FK_AssessmentLibrary_AssessmentDomain",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplexityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionUniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QuestionTextFormatted = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Complexities_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexities",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionType_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionType",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDomainLimitTrackers",
                columns: table => new
                {
                    AssessmentDomainLimitTrackerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplexityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentDomainLimit = table.Column<int>(type: "int", nullable: true),
                    QuestionsPresentedCount = table.Column<int>(type: "int", nullable: true),
                    AssessmentDomainDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDomainLimitTrackers", x => x.AssessmentDomainLimitTrackerId);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTrackers_AssessmentDomain_AssessmentDomainDomainId",
                        column: x => x.AssessmentDomainDomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTrackers_Complexities_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexities",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTrackers_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvidenceReports",
                columns: table => new
                {
                    EvidenceReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinishedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrustScore = table.Column<int>(type: "int", nullable: true),
                    Device = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Screen_recording_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test_taker_photo_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenceReports", x => x.EvidenceReportId);
                    table.ForeignKey(
                        name: "FK_EvidenceReports_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentEvidenceDetail",
                columns: table => new
                {
                    UserAssessmentEvidenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestAttemptId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HashedTestAttemptId = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentEvidenceDetail", x => x.UserAssessmentEvidenceId);
                    table.ForeignKey(
                        name: "FK_UserAssessmentEvidenceDetail_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentIAI",
                columns: table => new
                {
                    UserAssessmentIAIId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobRequirementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIdIAI = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentIAI", x => x.UserAssessmentIAIId);
                    table.ForeignKey(
                        name: "FK_UserAssessmentIAI_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId");
                    table.ForeignKey(
                        name: "FK_UserAssessmentIAI_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentPanel",
                columns: table => new
                {
                    UserAssessmentPanelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PanelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentPanel", x => x.UserAssessmentPanelId);
                    table.ForeignKey(
                        name: "FK_UserAssessmentPanel_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessmentPanel_UserMasters_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMasters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    AnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerOrder = table.Column<int>(type: "int", nullable: true),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestions",
                columns: table => new
                {
                    AssessmentQuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentOrder = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestions", x => x.AssessmentQuestionId);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestions_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LibraryQuestions",
                columns: table => new
                {
                    LibraryQuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssessmentOrder = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryQuestions", x => x.LibraryQuestionId);
                    table.ForeignKey(
                        name: "FK_LibraryQuestions_Assessments_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessments",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LibraryQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentTrackers",
                columns: table => new
                {
                    UserAssessmentTrackerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Presented = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentTrackers", x => x.UserAssessmentTrackerId);
                    table.ForeignKey(
                        name: "FK_UserAssessmentTrackers_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAssessmentTrackers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_UserAssessmentTrackers_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EvidenceReportDetails",
                columns: table => new
                {
                    EvidenceReportDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvidenceReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Evidence_label = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evidence_iso_datetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Is_violation = table.Column<bool>(type: "bit", nullable: true),
                    Evidence_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenceReportDetails", x => x.EvidenceReportDetailId);
                    table.ForeignKey(
                        name: "FK_EvidenceReportDetails_EvidenceReports_EvidenceReportId",
                        column: x => x.EvidenceReportId,
                        principalTable: "EvidenceReports",
                        principalColumn: "EvidenceReportId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserResponse",
                columns: table => new
                {
                    UserResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    UserAssessmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponse", x => x.UserResponseId);
                    table.ForeignKey(
                        name: "FK_UserResponse_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserResponse_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserResponse_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserResponse_UserAssessments_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessments",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserResponseMultipleAnswer",
                columns: table => new
                {
                    UserResponseAnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrimaryUserResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SecondaryUserResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponseMultipleAnswer", x => x.UserResponseAnswerId);
                    table.ForeignKey(
                        name: "FK_UserResponseMultipleAnswer_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserResponseMultipleAnswer_UserResponse_PrimaryUserResponseId",
                        column: x => x.PrimaryUserResponseId,
                        principalTable: "UserResponse",
                        principalColumn: "UserResponseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserResponseMultipleAnswer_UserResponse_SecondaryUserResponseId",
                        column: x => x.SecondaryUserResponseId,
                        principalTable: "UserResponse",
                        principalColumn: "UserResponseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetails_AssessmentDomainDomainId",
                table: "AssessmentDetails",
                column: "AssessmentDomainDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetails_AssessmentId",
                table: "AssessmentDetails",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetails_ComplexityId",
                table: "AssessmentDetails",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomain_CompilerId",
                table: "AssessmentDomain",
                column: "CompilerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomain_PrimaryDomainId",
                table: "AssessmentDomain",
                column: "PrimaryDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTrackers_AssessmentDomainDomainId",
                table: "AssessmentDomainLimitTrackers",
                column: "AssessmentDomainDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTrackers_ComplexityId",
                table: "AssessmentDomainLimitTrackers",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTrackers_UserAssessmentId",
                table: "AssessmentDomainLimitTrackers",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentLibrary_DomainId",
                table: "AssessmentLibrary",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestions_AssessmentId",
                table: "AssessmentQuestions",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestions_QuestionId",
                table: "AssessmentQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ClientId",
                table: "Assessments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_SecondaryClientId",
                table: "Assessments",
                column: "SecondaryClientId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenceReportDetails_EvidenceReportId",
                table: "EvidenceReportDetails",
                column: "EvidenceReportId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenceReports_UserAssessmentId",
                table: "EvidenceReports",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryQuestions_AssessmentId",
                table: "LibraryQuestions",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryQuestions_QuestionId",
                table: "LibraryQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ComplexityId",
                table: "Questions",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_DomainId",
                table: "Questions",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Client1Id",
                table: "Role",
                column: "Client1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Client2Id",
                table: "Role",
                column: "Client2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ClientId",
                table: "Role",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentEvidenceDetail_UserAssessmentId",
                table: "UserAssessmentEvidenceDetail",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentIAI_UserAssessmentId",
                table: "UserAssessmentIAI",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentIAI_UserId",
                table: "UserAssessmentIAI",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentPanel_UserAssessmentId",
                table: "UserAssessmentPanel",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentPanel_UserId",
                table: "UserAssessmentPanel",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_AssessmentId",
                table: "UserAssessments",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_ClientId",
                table: "UserAssessments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_SecondaryAssessmentId",
                table: "UserAssessments",
                column: "SecondaryAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_SecondaryClientId",
                table: "UserAssessments",
                column: "SecondaryClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_UserAssessmentStatusId",
                table: "UserAssessments",
                column: "UserAssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessments_UserId",
                table: "UserAssessments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTrackers_DomainId",
                table: "UserAssessmentTrackers",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTrackers_QuestionId",
                table: "UserAssessmentTrackers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTrackers_UserAssessmentId",
                table: "UserAssessmentTrackers",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMasters_ClientId",
                table: "UserMasters",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponse_AnswerId",
                table: "UserResponse",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponse_ClientId",
                table: "UserResponse",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponse_QuestionId",
                table: "UserResponse",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponse_UserAssessmentId",
                table: "UserResponse",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponseMultipleAnswer_AnswerId",
                table: "UserResponseMultipleAnswer",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponseMultipleAnswer_PrimaryUserResponseId",
                table: "UserResponseMultipleAnswer",
                column: "PrimaryUserResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserResponseMultipleAnswer_SecondaryUserResponseId",
                table: "UserResponseMultipleAnswer",
                column: "SecondaryUserResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Client1Id",
                table: "UserRoles",
                column: "Client1Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ClientId",
                table: "UserRoles",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Role1Id",
                table: "UserRoles",
                column: "Role1Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserMasterUserId",
                table: "UserRoles",
                column: "UserMasterUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentDetails");

            migrationBuilder.DropTable(
                name: "AssessmentDomainLimitTrackers");

            migrationBuilder.DropTable(
                name: "AssessmentLibrary");

            migrationBuilder.DropTable(
                name: "AssessmentQuestions");

            migrationBuilder.DropTable(
                name: "ClientLogoes");

            migrationBuilder.DropTable(
                name: "EvidenceReportDetails");

            migrationBuilder.DropTable(
                name: "LibraryQuestions");

            migrationBuilder.DropTable(
                name: "ProctoringResults");

            migrationBuilder.DropTable(
                name: "RegisteredCompanies");

            migrationBuilder.DropTable(
                name: "UserAssessmentEvidenceDetail");

            migrationBuilder.DropTable(
                name: "UserAssessmentFiles");

            migrationBuilder.DropTable(
                name: "UserAssessmentIAI");

            migrationBuilder.DropTable(
                name: "UserAssessmentPanel");

            migrationBuilder.DropTable(
                name: "UserAssessmentProctorResults");

            migrationBuilder.DropTable(
                name: "UserAssessmentTrackers");

            migrationBuilder.DropTable(
                name: "UserResponseFreeTextAnswers");

            migrationBuilder.DropTable(
                name: "UserResponseMultipleAnswer");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "EvidenceReports");

            migrationBuilder.DropTable(
                name: "UserResponse");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserAssessments");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "UserAssessmentStatu");

            migrationBuilder.DropTable(
                name: "UserMasters");

            migrationBuilder.DropTable(
                name: "AssessmentDomain");

            migrationBuilder.DropTable(
                name: "Complexities");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Compilers");

            migrationBuilder.DropTable(
                name: "PrimaryDomains");
        }
    }
}
