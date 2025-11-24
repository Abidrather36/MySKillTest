using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySkillTest.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientConfigurationJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoweredApplicationUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "ClientLogo",
                columns: table => new
                {
                    ClientLogoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ClientLogoGuid = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLogo", x => x.ClientLogoId);
                });

            migrationBuilder.CreateTable(
                name: "Compiler",
                columns: table => new
                {
                    CompilerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompilerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompilerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonacoEditorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compiler", x => x.CompilerId);
                });

            migrationBuilder.CreateTable(
                name: "Complexity",
                columns: table => new
                {
                    ComplexityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplexityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complexity", x => x.ComplexityId);
                });

            migrationBuilder.CreateTable(
                name: "PrimaryDomain",
                columns: table => new
                {
                    PrimaryDomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryDomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryDomainShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryDomain", x => x.PrimaryDomainId);
                });

            migrationBuilder.CreateTable(
                name: "ProctoringResult",
                columns: table => new
                {
                    ProctoringResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProctoringResult", x => x.ProctoringResultId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionType",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MultipleChoice = table.Column<bool>(type: "bit", nullable: true),
                    Coding = table.Column<bool>(type: "bit", nullable: true),
                    AllowMultipleSelection = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                name: "RegisteredCompany",
                columns: table => new
                {
                    RegisteredCompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredCompany", x => x.RegisteredCompanyId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentFile",
                columns: table => new
                {
                    UserAssessmentFileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentFile", x => x.UserAssessmentFileId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentProctorResult",
                columns: table => new
                {
                    UserAssessmentProctorResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    ResultContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDFContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentProctorResult", x => x.UserAssessmentProctorResultId);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentStatu",
                columns: table => new
                {
                    UserAssessmentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAssessmentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                name: "UserResponseFreeTextAnswer",
                columns: table => new
                {
                    UserResponseFreeTextAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserResponseId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnswerCompiled = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResponseFreeTextAnswer", x => x.UserResponseFreeTextAnswerId);
                });

            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    AssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeLimitInMinutes = table.Column<int>(type: "int", nullable: false),
                    AttemptsAllowed = table.Column<int>(type: "int", nullable: true),
                    AllowPausing = table.Column<bool>(type: "bit", nullable: true),
                    RandomizeQuestions = table.Column<bool>(type: "bit", nullable: true),
                    ReadQuestionsFromAssessment = table.Column<bool>(type: "bit", nullable: true),
                    IsFreezed = table.Column<bool>(type: "bit", nullable: true),
                    IsProctorRequired = table.Column<bool>(type: "bit", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.AssessmentId);
                    table.ForeignKey(
                        name: "FK_Assessment_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoweredRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Role_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId");
                });

            migrationBuilder.CreateTable(
                name: "UserMaster",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoweredUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastActivityDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordFormat = table.Column<int>(type: "int", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastPasswordChangedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastLockoutDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FailedPasswordAttemptCount = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PasswordResetRequestActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<long>(type: "bigint", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMaster", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserMaster_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDomain",
                columns: table => new
                {
                    DomainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompilerId = table.Column<int>(type: "int", nullable: true),
                    PrimaryDomainId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_AssessmentDomain_Compiler_CompilerId",
                        column: x => x.CompilerId,
                        principalTable: "Compiler",
                        principalColumn: "CompilerId");
                    table.ForeignKey(
                        name: "FK_AssessmentDomain_PrimaryDomain_PrimaryDomainId",
                        column: x => x.PrimaryDomainId,
                        principalTable: "PrimaryDomain",
                        principalColumn: "PrimaryDomainId");
                });

            migrationBuilder.CreateTable(
                name: "UserAssessment",
                columns: table => new
                {
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    EndDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    TimeRemainingInMinutes = table.Column<int>(type: "int", nullable: true),
                    Attempts = table.Column<int>(type: "int", nullable: true),
                    ShortUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RunningScore = table.Column<int>(type: "int", nullable: true),
                    TotalScore = table.Column<int>(type: "int", nullable: true),
                    StatusUpdateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    StatusUpdatedBy = table.Column<int>(type: "int", nullable: true),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    UserAssessmentStatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessment", x => x.UserAssessmentId);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAssessment_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserAssessment_UserAssessmentStatu_UserAssessmentStatusId",
                        column: x => x.UserAssessmentStatusId,
                        principalTable: "UserAssessmentStatu",
                        principalColumn: "UserAssessmentStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAssessment_UserMaster_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMaster",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRole_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_UserMaster_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMaster",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDetail",
                columns: table => new
                {
                    AssessmentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfQuestions = table.Column<int>(type: "int", nullable: false),
                    NoOfCodingQuestions = table.Column<int>(type: "int", nullable: false),
                    TimeLimitInMinutes = table.Column<int>(type: "int", nullable: true),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    ComplexityId = table.Column<int>(type: "int", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDetail", x => x.AssessmentDetailId);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentDetail_Complexity_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexity",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentLibrary",
                columns: table => new
                {
                    LibraryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_AssessmentLibrary_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionUniqueId = table.Column<int>(type: "int", nullable: true),
                    QuestionTextFormatted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    ComplexityId = table.Column<int>(type: "int", nullable: false),
                    QuestionTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Question_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_Complexity_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexity",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Question_QuestionType_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionType",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentDomainLimitTracker",
                columns: table => new
                {
                    AssessmentDomainLimitTrackerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentDomainLimit = table.Column<int>(type: "int", nullable: true),
                    QuestionsPresentedCount = table.Column<int>(type: "int", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    ComplexityId = table.Column<int>(type: "int", nullable: false),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentDomainLimitTracker", x => x.AssessmentDomainLimitTrackerId);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTracker_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTracker_Complexity_ComplexityId",
                        column: x => x.ComplexityId,
                        principalTable: "Complexity",
                        principalColumn: "ComplexityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentDomainLimitTracker_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvidenceReport",
                columns: table => new
                {
                    EvidenceReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinishedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrustScore = table.Column<int>(type: "int", nullable: true),
                    Device = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Screen_recording_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Test_taker_photo_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenceReport", x => x.EvidenceReportId);
                    table.ForeignKey(
                        name: "FK_EvidenceReport_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentEvidenceDetail",
                columns: table => new
                {
                    UserAssessmentEvidenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAttemptId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashedTestAttemptId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserAssessmentEvidenceDetail_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentIAI",
                columns: table => new
                {
                    UserAssessmentIAIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobRequirementId = table.Column<int>(type: "int", nullable: false),
                    UserIdIAI = table.Column<int>(type: "int", nullable: false),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserAssessmentIAI_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAssessmentIAI_UserMaster_UserId",
                        column: x => x.UserId,
                        principalTable: "UserMaster",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentPanel",
                columns: table => new
                {
                    UserAssessmentPanelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanelId = table.Column<int>(type: "int", nullable: false),
                    IsReviewed = table.Column<bool>(type: "bit", nullable: true),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    UserMasterUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserAssessmentPanel_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAssessmentPanel_UserMaster_UserMasterUserId",
                        column: x => x.UserMasterUserId,
                        principalTable: "UserMaster",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerOrder = table.Column<int>(type: "int", nullable: true),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentQuestion",
                columns: table => new
                {
                    AssessmentQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentOrder = table.Column<int>(type: "int", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestion", x => x.AssessmentQuestionId);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestion_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryQuestion",
                columns: table => new
                {
                    LibraryQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssessmentOrder = table.Column<int>(type: "int", nullable: false),
                    AssessmentId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryQuestion", x => x.LibraryQuestionId);
                    table.ForeignKey(
                        name: "FK_LibraryQuestion_Assessment_AssessmentId",
                        column: x => x.AssessmentId,
                        principalTable: "Assessment",
                        principalColumn: "AssessmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAssessmentTracker",
                columns: table => new
                {
                    UserAssessmentTrackerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presented = table.Column<bool>(type: "bit", nullable: true),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssessmentTracker", x => x.UserAssessmentTrackerId);
                    table.ForeignKey(
                        name: "FK_UserAssessmentTracker_AssessmentDomain_DomainId",
                        column: x => x.DomainId,
                        principalTable: "AssessmentDomain",
                        principalColumn: "DomainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAssessmentTracker_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId");
                    table.ForeignKey(
                        name: "FK_UserAssessmentTracker_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvidenceReportDetail",
                columns: table => new
                {
                    EvidenceReportDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Evidence_label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evidence_iso_datetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Is_violation = table.Column<bool>(type: "bit", nullable: true),
                    Evidence_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceReportId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidenceReportDetail", x => x.EvidenceReportDetailId);
                    table.ForeignKey(
                        name: "FK_EvidenceReportDetail_EvidenceReport_EvidenceReportId",
                        column: x => x.EvidenceReportId,
                        principalTable: "EvidenceReport",
                        principalColumn: "EvidenceReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserResponse",
                columns: table => new
                {
                    UserResponseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    UserAssessmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserResponse_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResponse_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResponse_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserResponse_UserAssessment_UserAssessmentId",
                        column: x => x.UserAssessmentId,
                        principalTable: "UserAssessment",
                        principalColumn: "UserAssessmentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserResponseMultipleAnswer",
                columns: table => new
                {
                    UserResponseAnswerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    UserResponseId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_UserResponseMultipleAnswer_Answer_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answer",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserResponseMultipleAnswer_UserResponse_UserResponseId",
                        column: x => x.UserResponseId,
                        principalTable: "UserResponse",
                        principalColumn: "UserResponseId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_ClientId",
                table: "Assessment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_AssessmentId",
                table: "AssessmentDetail",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_ComplexityId",
                table: "AssessmentDetail",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDetail_DomainId",
                table: "AssessmentDetail",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomain_CompilerId",
                table: "AssessmentDomain",
                column: "CompilerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomain_PrimaryDomainId",
                table: "AssessmentDomain",
                column: "PrimaryDomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTracker_ComplexityId",
                table: "AssessmentDomainLimitTracker",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTracker_DomainId",
                table: "AssessmentDomainLimitTracker",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentDomainLimitTracker_UserAssessmentId",
                table: "AssessmentDomainLimitTracker",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentLibrary_DomainId",
                table: "AssessmentLibrary",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestion_AssessmentId",
                table: "AssessmentQuestion",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestion_QuestionId",
                table: "AssessmentQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenceReport_UserAssessmentId",
                table: "EvidenceReport",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidenceReportDetail_EvidenceReportId",
                table: "EvidenceReportDetail",
                column: "EvidenceReportId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryQuestion_AssessmentId",
                table: "LibraryQuestion",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryQuestion_QuestionId",
                table: "LibraryQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ComplexityId",
                table: "Question",
                column: "ComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_DomainId",
                table: "Question",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_QuestionTypeId",
                table: "Question",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ClientId",
                table: "Role",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessment_AssessmentId",
                table: "UserAssessment",
                column: "AssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessment_ClientId",
                table: "UserAssessment",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessment_UserAssessmentStatusId",
                table: "UserAssessment",
                column: "UserAssessmentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessment_UserId",
                table: "UserAssessment",
                column: "UserId");

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
                name: "IX_UserAssessmentPanel_UserMasterUserId",
                table: "UserAssessmentPanel",
                column: "UserMasterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTracker_DomainId",
                table: "UserAssessmentTracker",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTracker_QuestionId",
                table: "UserAssessmentTracker",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssessmentTracker_UserAssessmentId",
                table: "UserAssessmentTracker",
                column: "UserAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMaster_ClientId",
                table: "UserMaster",
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
                name: "IX_UserResponseMultipleAnswer_UserResponseId",
                table: "UserResponseMultipleAnswer",
                column: "UserResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_ClientId",
                table: "UserRole",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentDetail");

            migrationBuilder.DropTable(
                name: "AssessmentDomainLimitTracker");

            migrationBuilder.DropTable(
                name: "AssessmentLibrary");

            migrationBuilder.DropTable(
                name: "AssessmentQuestion");

            migrationBuilder.DropTable(
                name: "ClientLogo");

            migrationBuilder.DropTable(
                name: "EvidenceReportDetail");

            migrationBuilder.DropTable(
                name: "LibraryQuestion");

            migrationBuilder.DropTable(
                name: "ProctoringResult");

            migrationBuilder.DropTable(
                name: "RegisteredCompany");

            migrationBuilder.DropTable(
                name: "UserAssessmentEvidenceDetail");

            migrationBuilder.DropTable(
                name: "UserAssessmentFile");

            migrationBuilder.DropTable(
                name: "UserAssessmentIAI");

            migrationBuilder.DropTable(
                name: "UserAssessmentPanel");

            migrationBuilder.DropTable(
                name: "UserAssessmentProctorResult");

            migrationBuilder.DropTable(
                name: "UserAssessmentTracker");

            migrationBuilder.DropTable(
                name: "UserResponseFreeTextAnswer");

            migrationBuilder.DropTable(
                name: "UserResponseMultipleAnswer");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "EvidenceReport");

            migrationBuilder.DropTable(
                name: "UserResponse");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "UserAssessment");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Assessment");

            migrationBuilder.DropTable(
                name: "UserAssessmentStatu");

            migrationBuilder.DropTable(
                name: "UserMaster");

            migrationBuilder.DropTable(
                name: "AssessmentDomain");

            migrationBuilder.DropTable(
                name: "Complexity");

            migrationBuilder.DropTable(
                name: "QuestionType");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Compiler");

            migrationBuilder.DropTable(
                name: "PrimaryDomain");
        }
    }
}
