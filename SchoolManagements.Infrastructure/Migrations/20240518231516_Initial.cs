using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagements.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sm");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamenSchedule",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamenSchedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamType",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeeType",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffSalary",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FestivalBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Allowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HousingAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TransportationAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SavingFund = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Taxes = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSalary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Standard",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniqueStaffAttendanceNumber = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Designation = table.Column<int>(type: "int", nullable: true),
                    BankAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccountNumber = table.Column<int>(type: "int", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    StaffSalaryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "sm",
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_StaffSalary_StaffSalaryId",
                        column: x => x.StaffSalaryId,
                        principalSchema: "sm",
                        principalTable: "StaffSalary",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExamScheduleStandard",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleId = table.Column<int>(type: "int", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: false),
                    StandardId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamScheduleStandard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamScheduleStandard_ExamenSchedule_ExamScheduleId",
                        column: x => x.ExamScheduleId,
                        principalSchema: "sm",
                        principalTable: "ExamenSchedule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamScheduleStandard_Standard_StandardId",
                        column: x => x.StandardId,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamScheduleStandard_Standard_StandardId1",
                        column: x => x.StandardId1,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionNo = table.Column<int>(type: "int", nullable: true),
                    EnrollmentNo = table.Column<int>(type: "int", nullable: true),
                    UniqueStudentAttendanceNumber = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentGender = table.Column<int>(type: "int", nullable: true),
                    StudentReligion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNIDNumber = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    StudentContactNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentContactNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemporaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherNID = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    FatherContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherNID = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: true),
                    MotherContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGuardianName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalGuardianContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Standard_StandardId",
                        column: x => x.StandardId,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectCode = table.Column<int>(type: "int", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: true),
                    StandardId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Standard_StandardId",
                        column: x => x.StandardId,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subject_Standard_StandardId1",
                        column: x => x.StandardId1,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffExperience",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Achievements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffExperience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffExperience_Staff_StaffId",
                        column: x => x.StaffId,
                        principalSchema: "sm",
                        principalTable: "Staff",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MonthlyPayment",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    TotalFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Waver = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousDue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonthlyPayment_Student_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "sm",
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OthersPayment",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OthersPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OthersPayment_Student_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "sm",
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentMarksDetails",
                schema: "sm",
                columns: table => new
                {
                    MarkEntryId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObtainedScore = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    PassStatus = table.Column<int>(type: "int", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMarksDetails", x => new { x.StudentId, x.MarkEntryId });
                    table.ForeignKey(
                        name: "FK_StudentMarksDetails_Student_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "sm",
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamSubject",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamScheduleStandardId = table.Column<int>(type: "int", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ExamTypeId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExamEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamSubject_ExamScheduleStandard_ExamScheduleStandardId",
                        column: x => x.ExamScheduleStandardId,
                        principalSchema: "sm",
                        principalTable: "ExamScheduleStandard",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExamSubject_ExamType_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalSchema: "sm",
                        principalTable: "ExamType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalSchema: "sm",
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicMonth",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthId = table.Column<int>(type: "int", nullable: false),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    monthlyPaymentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicMonth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicMonth_MonthlyPayment_monthlyPaymentId",
                        column: x => x.monthlyPaymentId,
                        principalSchema: "sm",
                        principalTable: "MonthlyPayment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DueBalance",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    DueBalanceAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DueBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DueBalance_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalSchema: "sm",
                        principalTable: "MonthlyPayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DueBalance_Student_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "sm",
                        principalTable: "Student",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetail",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentDetail_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalSchema: "sm",
                        principalTable: "MonthlyPayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMonth",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthlyPaymentId = table.Column<int>(type: "int", nullable: false),
                    MonthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMonth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMonth_MonthlyPayment_MonthlyPaymentId",
                        column: x => x.MonthlyPaymentId,
                        principalSchema: "sm",
                        principalTable: "MonthlyPayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fee",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeTypeId = table.Column<int>(type: "int", nullable: false),
                    StandardId = table.Column<int>(type: "int", nullable: false),
                    PaymentFrequency = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    monthlyPaymentId = table.Column<int>(type: "int", nullable: true),
                    othersPaymentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fee_FeeType_FeeTypeId",
                        column: x => x.FeeTypeId,
                        principalSchema: "sm",
                        principalTable: "FeeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fee_MonthlyPayment_monthlyPaymentId",
                        column: x => x.monthlyPaymentId,
                        principalSchema: "sm",
                        principalTable: "MonthlyPayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fee_OthersPayment_othersPaymentId",
                        column: x => x.othersPaymentId,
                        principalSchema: "sm",
                        principalTable: "OthersPayment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fee_Standard_StandardId",
                        column: x => x.StandardId,
                        principalSchema: "sm",
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherPaymentDetail",
                schema: "sm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false),
                    OthersPaymentId = table.Column<int>(type: "int", nullable: false),
                    FeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletededDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherPaymentDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherPaymentDetail_OthersPayment_OthersPaymentId",
                        column: x => x.OthersPaymentId,
                        principalSchema: "sm",
                        principalTable: "OthersPayment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "DeletededDate", "DepartmentName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4655), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4660), "Teacher", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4659) },
                    { 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4669), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4670), "Account", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4670) },
                    { 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4671), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4672), "Administration", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4672) },
                    { 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4673), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4673), "Student Affairs", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4673) },
                    { 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4674), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4675), "Counseling", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4674) },
                    { 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4675), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4676), "Sports", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4676) },
                    { 7, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4677), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4677), "Library", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4677) },
                    { 8, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4678), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4679), "Maintenance", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4678) }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "ExamType",
                columns: new[] { "Id", "CreatedDate", "DeletededDate", "ExamTypeName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4823), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4823), "Midterm", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4823) },
                    { 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4830), "Final", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4829) },
                    { 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4832), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4833), "Practical", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4833) },
                    { 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4835), "Monthly Exam", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4834) },
                    { 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4835), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4836), "Lab Exam", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4836) }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "FeeType",
                columns: new[] { "Id", "CreatedDate", "DeletededDate", "ModifiedDate", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4873), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4873), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4873), "Registration Fee" },
                    { 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4876), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4876), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4876), "Tuition Fee" },
                    { 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4877), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4878), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4877), "Library Fee" },
                    { 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4879), "Examination Fee" },
                    { 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4880), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4881), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4880), "Sports Fee" },
                    { 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4881), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4882), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4882), "Transportation Fee" }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "StaffExperience",
                columns: new[] { "Id", "Achievements", "CompanyName", "CreatedDate", "DeletededDate", "Designation", "JoiningDate", "LeavingDate", "ModifiedDate", "Responsibilities", "StaffId" },
                values: new object[,]
                {
                    { 1, "Received Employee of the Month award.", "ABC Company", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5258), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5258), "Software Engineer", new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5258), "Developed web applications.", null },
                    { 2, "Implemented a new data visualization system.", "XYZ Corporation", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5268), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5268), "Data Analyst", new DateTime(2018, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5268), "Analyzed data to provide insights.", null },
                    { 3, "Successfully delivered multiple projects on time.", "EFG Ltd.", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5282), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5282), "Project Manager", new DateTime(2016, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5282), "Led a team of developers.", null }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "StaffSalary",
                columns: new[] { "Id", "Allowance", "BasicSalary", "CreatedDate", "DeletededDate", "FestivalBonus", "HousingAllowance", "MedicalAllowance", "ModifiedDate", "NetSalary", "SavingFund", "StaffName", "Taxes", "TransportationAllowance" },
                values: new object[,]
                {
                    { 1, 500m, 5000m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4912), 1000m, 800m, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4912), null, 200m, "Jamir King", 500m, 200m },
                    { 2, 500m, 5000m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4919), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4920), 1000m, 800m, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4920), null, 200m, "Jamir Jamidar", 500m, 200m },
                    { 3, 500m, 5000m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4927), 1000m, 800m, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4927), null, 200m, "Jamir Amir", 500m, 200m }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Standard",
                columns: new[] { "Id", "CreatedDate", "DeletededDate", "ModifiedDate", "StandardCapacity", "StandardName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4968), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4969), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4969), "30", "Class One" },
                    { 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4972), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4973), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4972), "35", "Class Two" },
                    { 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4975), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4975), "32", "Class Three" },
                    { 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4976), "28", "Class Four" },
                    { 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4978), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4978), "30", "Class Five" },
                    { 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4979), "30", "Class Six" },
                    { 7, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4980), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4981), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4981), "30", "Class Seven" },
                    { 8, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4982), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4982), "30", "Class Eight" },
                    { 9, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4984), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4984), "30", "Class Nine" },
                    { 10, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4985), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4986), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(4985), "30", "Class Ten" }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Fee",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletededDate", "DueDate", "FeeTypeId", "ModifiedDate", "PaymentFrequency", "StandardId", "monthlyPaymentId", "othersPaymentId" },
                values: new object[,]
                {
                    { 1, 1500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5361), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5362), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5361), 1, 1, null, null },
                    { 2, 500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5367), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5368), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5367), 0, 1, null, null },
                    { 3, 200m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5371), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5371), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5371), 0, 1, null, null },
                    { 4, 100m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5374), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5374), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5374), 0, 1, null, null },
                    { 5, 250m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5398), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5399), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5399), 5, 1, null, null },
                    { 6, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5415), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5414), 5, 1, null, null },
                    { 7, 1500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5418), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5418), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5418), 1, 2, null, null },
                    { 8, 500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5421), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5421), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5421), 0, 2, null, null },
                    { 9, 200m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5424), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5424), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5424), 0, 2, null, null },
                    { 10, 100m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5427), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5427), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5427), 0, 2, null, null },
                    { 11, 250m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5430), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5430), 5, 2, null, null },
                    { 12, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5433), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5433), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5433), 5, 2, null, null },
                    { 13, 1500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5436), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5436), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5436), 1, 3, null, null },
                    { 14, 500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5439), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5439), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5439), 0, 3, null, null },
                    { 15, 200m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5442), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5442), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5442), 0, 3, null, null },
                    { 16, 100m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5445), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5445), 0, 3, null, null },
                    { 17, 250m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5448), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5448), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5448), 5, 3, null, null },
                    { 18, 300m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5453), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5453), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5453), 5, 3, null, null },
                    { 19, 1500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5458), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5459), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5459), 1, 4, null, null },
                    { 20, 500m, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5461), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5462), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5462), 0, 4, null, null }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Staff",
                columns: new[] { "Id", "BankAccountName", "BankAccountNumber", "BankBranch", "BankName", "ContactNumber1", "CreatedDate", "DOB", "DeletededDate", "DepartmentId", "Designation", "Email", "FatherName", "Gender", "JoiningDate", "ModifiedDate", "MotherName", "PermanentAddress", "Qualifications", "StaffName", "StaffSalaryId", "Status", "TemporaryAddress", "UniqueStaffAttendanceNumber" },
                values: new object[,]
                {
                    { 1, "John Doe", 1234567890, "XYZ Branch", "ABC Bank", "1234567890", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5311), new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5311), 1, 13, "john.doe@example.com", "Michael Doe", 0, new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5311), "Alice Doe", "Permanent Address", "Bachelor's in Computer Science", "Jamir King", 1, "Active", "Temporary Address", 201 },
                    { 2, "Alice Smith", 9873210, "UVW Branch", "DEF Bank", "9876543210", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5323), new DateTime(1990, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5324), 2, 2, "alice.smith@example.com", "David Smith", 1, new DateTime(2015, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5323), "Emily Smith", "Permanent Address", "Master's in Education", "Jamir Jamidar", 2, "Active", "Temporary Address", 202 },
                    { 3, "John Doe", 1234567890, "Main Street", "Anytown Bank", "555-123-4567", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5331), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5331), 3, 7, "john.doe@example.com", "Richard Doe", 0, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5331), "Jane Doe", "456 Elm Street, Anytown", "Bachelor of Science in Mathematics", "Jamir Amir", 3, "Active", "123 Main Street, Anytown", 203 }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Student",
                columns: new[] { "Id", "AdmissionNo", "CreatedDate", "DeletededDate", "EnrollmentNo", "FatherContactNumber", "FatherNID", "FatherName", "LocalGuardianContactNumber", "LocalGuardianName", "ModifiedDate", "MotherContactNumber", "MotherNID", "MotherName", "PermanentAddress", "StandardId", "StudentBloodGroup", "StudentContactNumber1", "StudentContactNumber2", "StudentDOB", "StudentEmail", "StudentGender", "StudentNIDNumber", "StudentName", "StudentNationality", "StudentReligion", "TemporaryAddress", "UniqueStudentAttendanceNumber" },
                values: new object[,]
                {
                    { 1, 1000, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5011), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5012), 2000, "9876543210", "17948678987624322", "Michael Doe", "9876543230", "Jane Smith", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5011), "9876543220", "17948678987754322", "Alice Doe", "123 Main Street, City, Country", 1, "A+", "1234567890", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", 0, "12345678901234567", "John Doe", "Bangladeshi", null, "456 Elm Street, City, Country", 1000 },
                    { 2, 1001, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5019), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5020), 2001, "9876543220", "12345678901234567", "Abdul Rahman", "9876543240", "Kamal Ahmed", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5020), "9876543230", "12345678901234568", "Ayesha Rahman", "Dhaka, Bangladesh", 1, "B+", "9876543210", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatima.rahman@example.com", 1, "12345678901234567", "Fatima Rahman", "Bangladeshi", null, "Dhaka, Bangladesh", 1001 },
                    { 3, 1002, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5025), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5025), 2002, "9876543221", "98765432109876544", "Rahim Khan", "9876543241", "Kamal Ahmed", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5025), "9876543231", "98765432109876545", "Fatima Khan", "Chittagong, Bangladesh", 1, "O+", "9876543211", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "aryan.khan@example.com", 0, "98765432109876543", "Aryan Khan", "Bangladeshi", null, "Chittagong, Bangladesh", 1002 },
                    { 4, 1003, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5029), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5030), 2003, "9876543222", "76543210987654322", "Mahmud Ahmed", "9876543242", "Nadia Rahman", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5029), "9876543232", "76543210987654323", "Farida Ahmed", "Sylhet, Bangladesh", 2, "AB+", "9876543212", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tasnim.ahmed@example.com", 1, "76543210987654321", "Tasnim Ahmed", "Bangladeshi", null, "Sylhet, Bangladesh", 1003 },
                    { 5, 1004, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5033), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5034), 2004, "9876543223", "87654321098765433", "Nasir Khan", "9876543243", "Abdul Ali", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5033), "9876543233", "87654321098765434", "Sadia Khan", "Rajshahi, Bangladesh", 2, "A-", "9876543213", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "imran.khan@example.com", 0, "87654321098765432", "Imran Khan", "Bangladeshi", null, "Rajshahi, Bangladesh", 1004 },
                    { 6, 1005, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5037), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5038), 2005, "9876543224", "65432109876543211", "Hasan Rahman", "9876543244", "Khaled Islam", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5037), "9876543234", "65432109876543212", "Sabina Rahman", "Dhaka, Bangladesh", 2, "B-", "9876543214", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "anika.rahman@example.com", 1, "65432109876543210", "Anika Rahman", "Bangladeshi", null, "Dhaka, Bangladesh", 1005 },
                    { 7, 1006, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5083), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5084), 2006, "9876543225", "54321098765432110", "Rahman Islam", "9876543245", "Farid Ahmed", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5083), "9876543235", "54321098765432111", "Amina Islam", "Chittagong, Bangladesh", 3, "O-", "9876543215", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafiul.islam@example.com", 0, "54321098765432109", "Rafiul Islam", "Bangladeshi", null, "Chittagong, Bangladesh", 1006 },
                    { 8, 1007, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5087), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5088), 2007, "9876543226", "43210987654321099", "Akram Khan", "9876543246", "Ayesha Begum", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5088), "9876543236", "43210987654321100", "Taslima Khan", "Rajshahi, Bangladesh", 3, "AB-", "9876543216", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "zara.khan@example.com", 1, "43210987654321098", "Zara Khan", "Bangladeshi", null, "Rajshahi, Bangladesh", 1007 },
                    { 9, 1008, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5091), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5092), 2008, "9876543227", "32109876543210988", "Kamal Hossain", "9876543247", "Salam Ahmed", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5092), "9876543237", "32109876543210989", "Nazma Hossain", "Sylhet, Bangladesh", 3, "A+", "9876543217", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "arif.hossain@example.com", 0, "32109876543210987", "Arif Hossain", "Bangladeshi", null, "Sylhet, Bangladesh", 1008 },
                    { 10, 1009, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5096), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5097), 2009, "9876543228", "21098765432109877", "Jamil Akter", "9876543248", "Khaled Rahman", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5096), "9876543238", "21098765432109878", "Rina Akter", "Dhaka, Bangladesh", 4, "A-", "9876543218", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sabrina.akter@example.com", 1, "21098765432109876", "Sabrina Akter", "Bangladeshi", null, "Dhaka, Bangladesh", 1009 },
                    { 11, 1010, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5101), 2010, "9876543229", "10987654321098766", "Hasan Mahmud", "9876543249", "Farhana Akter", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5100), "9876543239", "10987654321098767", "Nazma Hasan", "Chittagong, Bangladesh", 4, "O-", "9876543219", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rahat.hasan@example.com", 0, "10987654321098765", "Rahat Hasan", "Bangladeshi", null, "Chittagong, Bangladesh", 1010 },
                    { 12, 1011, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5104), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5105), 2011, "9876543230", "09876543210987655", "Rahim Rahman", "9876543250", "Kamal Hossain", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5104), "9876543240", "09876543210987656", "Sara Rahman", "Rajshahi, Bangladesh", 4, "AB-", "9876543220", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "asif.rahman@example.com", 0, "09876543210987654", "Asif Rahman", "Bangladeshi", null, "Rajshahi, Bangladesh", 1011 },
                    { 13, 1012, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5108), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5108), 2012, "9876543231", "98765432109876544", "Akram Khan", "9876543251", "Ayesha Begum", new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5108), "9876543241", "98765432109876545", "Taslima Khan", "Sylhet, Bangladesh", 4, "A+", "9876543221", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehnaz.khan@example.com", 1, "98765432109876543", "Mehnaz Khan", "Bangladeshi", null, "Sylhet, Bangladesh", 1012 }
                });

            migrationBuilder.InsertData(
                schema: "sm",
                table: "Subject",
                columns: new[] { "Id", "CreatedDate", "DeletededDate", "ModifiedDate", "StandardId", "StandardId1", "SubjectCode", "SubjectName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5144), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5145), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5144), 1, null, 101, "Mathematics" },
                    { 2, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5147), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5147), 1, null, 102, "Bengali" },
                    { 3, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5149), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5150), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5149), 1, null, 103, "Physics" },
                    { 4, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5151), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5151), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5151), 2, null, 201, "Mathematics" },
                    { 5, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5153), 2, null, 202, "Bengali" },
                    { 6, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5154), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5155), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5155), 2, null, 203, "Physics" },
                    { 7, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5156), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5157), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5156), 3, null, 301, "Mathematics" },
                    { 8, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5158), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5158), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5158), 3, null, 302, "Bengali" },
                    { 9, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5160), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5160), 3, null, 303, "Physics" },
                    { 10, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5161), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5162), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5162), 4, null, 401, "Mathematics" },
                    { 11, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5163), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5163), 4, null, 402, "Bengali" },
                    { 12, new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 5, 18, 23, 15, 13, 585, DateTimeKind.Utc).AddTicks(5165), 4, null, 403, "Physics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicMonth_monthlyPaymentId",
                schema: "sm",
                table: "AcademicMonth",
                column: "monthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_DueBalance_MonthlyPaymentId",
                schema: "sm",
                table: "DueBalance",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_DueBalance_StudentId",
                schema: "sm",
                table: "DueBalance",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleStandard_ExamScheduleId",
                schema: "sm",
                table: "ExamScheduleStandard",
                column: "ExamScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleStandard_StandardId",
                schema: "sm",
                table: "ExamScheduleStandard",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamScheduleStandard_StandardId1",
                schema: "sm",
                table: "ExamScheduleStandard",
                column: "StandardId1");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_ExamScheduleStandardId",
                schema: "sm",
                table: "ExamSubject",
                column: "ExamScheduleStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_ExamTypeId",
                schema: "sm",
                table: "ExamSubject",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamSubject_SubjectId",
                schema: "sm",
                table: "ExamSubject",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_FeeTypeId",
                schema: "sm",
                table: "Fee",
                column: "FeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_monthlyPaymentId",
                schema: "sm",
                table: "Fee",
                column: "monthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_othersPaymentId",
                schema: "sm",
                table: "Fee",
                column: "othersPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_StandardId",
                schema: "sm",
                table: "Fee",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_MonthlyPayment_StudentId",
                schema: "sm",
                table: "MonthlyPayment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherPaymentDetail_OthersPaymentId",
                schema: "sm",
                table: "OtherPaymentDetail",
                column: "OthersPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OthersPayment_StudentId",
                schema: "sm",
                table: "OthersPayment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetail_MonthlyPaymentId",
                schema: "sm",
                table: "PaymentDetail",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMonth_MonthlyPaymentId",
                schema: "sm",
                table: "PaymentMonth",
                column: "MonthlyPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DepartmentId",
                schema: "sm",
                table: "Staff",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_StaffSalaryId",
                schema: "sm",
                table: "Staff",
                column: "StaffSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UniqueStaffAttendanceNumber",
                schema: "sm",
                table: "Staff",
                column: "UniqueStaffAttendanceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StaffExperience_StaffId",
                schema: "sm",
                table: "StaffExperience",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StandardId",
                schema: "sm",
                table: "Student",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UniqueStudentAttendanceNumber",
                schema: "sm",
                table: "Student",
                column: "UniqueStudentAttendanceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StandardId",
                schema: "sm",
                table: "Subject",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_StandardId1",
                schema: "sm",
                table: "Subject",
                column: "StandardId1");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectCode",
                schema: "sm",
                table: "Subject",
                column: "SubjectCode",
                unique: true,
                filter: "[SubjectCode] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicMonth",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "DueBalance",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "ExamSubject",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Fee",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "OtherPaymentDetail",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "PaymentDetail",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "PaymentMonth",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "StaffExperience",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "StudentMarksDetails",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "ExamScheduleStandard",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "ExamType",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Subject",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "FeeType",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "OthersPayment",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "MonthlyPayment",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Staff",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "ExamenSchedule",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "StaffSalary",
                schema: "sm");

            migrationBuilder.DropTable(
                name: "Standard",
                schema: "sm");
        }
    }
}
