using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolSystem.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    AttendanceStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.CheckConstraint("CK_Attendance_PersonType", "[PersonType] IN ('Student','Teacher','Employee')");
                    table.CheckConstraint("CK_Attendance_Status", "[AttendanceStatus] IN ('Present','Absent','Late','Excused')");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityCode = table.Column<string>(type: "nchar(20)", maxLength: 20, nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryCode = table.Column<string>(type: "nchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(type: "nchar(20)", maxLength: 20, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "StudentLevels",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LevelNumber = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLevels", x => x.LevelId);
                    table.CheckConstraint("CK_StudentLevel_Stage", "[Stage] IN (N'ابتدائي', N'أساسي', N'ثانوي')");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    BuildingNo = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Curriculums",
                columns: table => new
                {
                    CurriculumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculums", x => x.CurriculumId);
                    table.ForeignKey(
                        name: "FK_Curriculums_StudentLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "StudentLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    SocialStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChildrenInSchool = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                    table.ForeignKey(
                        name: "FK_Parents_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    EducationDegree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TeachingSubject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfVacations = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SocialStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teachers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Schedule = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_Employees_SupervisorId",
                        column: x => x.SupervisorId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    LocationId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Locations_LocationId1",
                        column: x => x.LocationId1,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_StudentLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "StudentLevels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    CurriculumId = table.Column<int>(type: "int", nullable: false),
                    StudentLevelLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.CheckConstraint("CK_Course_Dates", "[StartDate] <= [EndDate] OR [StartDate] IS NULL OR [EndDate] IS NULL");
                    table.ForeignKey(
                        name: "FK_Courses_Curriculums_CurriculumId",
                        column: x => x.CurriculumId,
                        principalTable: "Curriculums",
                        principalColumn: "CurriculumId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_StudentLevels_StudentLevelLevelId",
                        column: x => x.StudentLevelLevelId,
                        principalTable: "StudentLevels",
                        principalColumn: "LevelId");
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourseEnrollments",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Attendance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FinalGrade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseEnrollments", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourseEnrollments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourseEnrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentGrades",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ExamType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mark = table.Column<decimal>(type: "decimal(5,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrades", x => new { x.StudentId, x.CourseId, x.ExamType });
                    table.ForeignKey(
                        name: "FK_StudentGrades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentGrades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCode", "CityName", "CountryCode" },
                values: new object[,]
                {
                    { 1, "SA-RYD", "Riyadh", "SAU" },
                    { 2, "SA-JED", "Jeddah", "SAU" },
                    { 3, "AE-AUH", "Abu Dhabi", "ARE" },
                    { 4, "AE-DXB", "Dubai", "ARE" },
                    { 5, "OM-MSC", "Muscat", "OMN" },
                    { 6, "QA-DOH", "Doha", "QAT" },
                    { 7, "BH-MNL", "Manama", "BHR" },
                    { 8, "KW-KWI", "Kuwait City", "KWT" },
                    { 9, "YE-SAN", "Sana'a", "YEM" },
                    { 10, "YE-ADN", "Aden", "YEM" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 1, "SAU", "Saudi Arabia" },
                    { 2, "ARE", "United Arab Emirates" },
                    { 3, "OMN", "Oman" },
                    { 4, "QAT", "Qatar" },
                    { 5, "BHR", "Bahrain" },
                    { 6, "KWT", "Kuwait" },
                    { 7, "YEM", "Yemen" }
                });

            migrationBuilder.InsertData(
                table: "StudentLevels",
                columns: new[] { "LevelId", "LevelName", "LevelNumber", "Stage" },
                values: new object[,]
                {
                    { 1, "Grade 1", 1, "ابتدائي" },
                    { 2, "Grade 2", 2, "ابتدائي" },
                    { 3, "Grade 3", 3, "ابتدائي" },
                    { 4, "Grade 4", 4, "ابتدائي" },
                    { 5, "Grade 5", 5, "ابتدائي" },
                    { 6, "Grade 6", 6, "ابتدائي" },
                    { 7, "Grade 7", 7, "أساسي" },
                    { 8, "Grade 8", 8, "أساسي" },
                    { 9, "Grade 9", 9, "أساسي" },
                    { 10, "Grade 10", 10, "ثانوي" },
                    { 11, "Grade 11", 11, "ثانوي" },
                    { 12, "Grade 12", 12, "ثانوي" }
                });

            migrationBuilder.InsertData(
                table: "Curriculums",
                columns: new[] { "CurriculumId", "Description", "LevelId", "Name", "Semester" },
                values: new object[,]
                {
                    { 101, "Basic Yemeni curriculum for Grade 1", 1, "Yemeni Curriculum Grade 1", "First" },
                    { 102, "Basic Yemeni curriculum for Grade 2", 2, "Yemeni Curriculum Grade 2", "First" },
                    { 103, "Basic Yemeni curriculum for Grade 3", 3, "Yemeni Curriculum Grade 3", "First" },
                    { 104, "Basic Yemeni curriculum for Grade 4", 4, "Yemeni Curriculum Grade 4", "First" },
                    { 105, "Basic Yemeni curriculum for Grade 5", 5, "Yemeni Curriculum Grade 5", "First" },
                    { 106, "Basic Yemeni curriculum for Grade 6", 6, "Yemeni Curriculum Grade 6", "First" },
                    { 107, "Basic Yemeni curriculum for Grade 7", 7, "Yemeni Curriculum Grade 7", "First" },
                    { 108, "Basic Yemeni curriculum for Grade 8", 8, "Yemeni Curriculum Grade 8", "First" },
                    { 109, "Basic Yemeni curriculum for Grade 9", 9, "Yemeni Curriculum Grade 9", "First" },
                    { 110, "Basic Yemeni curriculum for Grade 10", 10, "Yemeni Curriculum Grade 10", "First" },
                    { 111, "Basic Yemeni curriculum for Grade 11", 11, "Yemeni Curriculum Grade 11", "First" },
                    { 112, "Basic Yemeni curriculum for Grade 12", 12, "Yemeni Curriculum Grade 12", "First" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "BuildingNo", "CityId", "CountryId", "Street" },
                values: new object[] { 1, "1", 1, 1, "Default St" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CurriculumId", "Description", "EndDate", "Name", "StartDate", "StudentLevelLevelId", "TeacherId" },
                values: new object[,]
                {
                    { 1000, 101, "Arabic for Grade 1", null, "Arabic - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4519), null, 1 },
                    { 1001, 101, "Mathematics for Grade 1", null, "Mathematics - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4540), null, 1 },
                    { 1002, 101, "Science for Grade 1", null, "Science - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4544), null, 1 },
                    { 1003, 101, "English for Grade 1", null, "English - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4547), null, 1 },
                    { 1004, 101, "Islamic for Grade 1", null, "Islamic - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4551), null, 1 },
                    { 1005, 101, "Social Studies for Grade 1", null, "Social Studies - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4555), null, 1 },
                    { 1006, 101, "Computer for Grade 1", null, "Computer - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4557), null, 1 },
                    { 1007, 101, "Physical Education for Grade 1", null, "Physical Education - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4560), null, 1 },
                    { 1008, 101, "Art for Grade 1", null, "Art - Grade 1", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4562), null, 1 },
                    { 1009, 102, "Arabic for Grade 2", null, "Arabic - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4566), null, 1 },
                    { 1010, 102, "Mathematics for Grade 2", null, "Mathematics - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4568), null, 1 },
                    { 1011, 102, "Science for Grade 2", null, "Science - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4571), null, 1 },
                    { 1012, 102, "English for Grade 2", null, "English - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4573), null, 1 },
                    { 1013, 102, "Islamic for Grade 2", null, "Islamic - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4575), null, 1 },
                    { 1014, 102, "Social Studies for Grade 2", null, "Social Studies - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4577), null, 1 },
                    { 1015, 102, "Computer for Grade 2", null, "Computer - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4579), null, 1 },
                    { 1016, 102, "Physical Education for Grade 2", null, "Physical Education - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4581), null, 1 },
                    { 1017, 102, "Art for Grade 2", null, "Art - Grade 2", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4591), null, 1 },
                    { 1018, 103, "Arabic for Grade 3", null, "Arabic - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4594), null, 1 },
                    { 1019, 103, "Mathematics for Grade 3", null, "Mathematics - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4596), null, 1 },
                    { 1020, 103, "Science for Grade 3", null, "Science - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4598), null, 1 },
                    { 1021, 103, "English for Grade 3", null, "English - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4600), null, 1 },
                    { 1022, 103, "Islamic for Grade 3", null, "Islamic - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4602), null, 1 },
                    { 1023, 103, "Social Studies for Grade 3", null, "Social Studies - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4604), null, 1 },
                    { 1024, 103, "Computer for Grade 3", null, "Computer - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4606), null, 1 },
                    { 1025, 103, "Physical Education for Grade 3", null, "Physical Education - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4608), null, 1 },
                    { 1026, 103, "Art for Grade 3", null, "Art - Grade 3", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4611), null, 1 },
                    { 1027, 104, "Arabic for Grade 4", null, "Arabic - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4613), null, 1 },
                    { 1028, 104, "Mathematics for Grade 4", null, "Mathematics - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4615), null, 1 },
                    { 1029, 104, "Science for Grade 4", null, "Science - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4616), null, 1 },
                    { 1030, 104, "English for Grade 4", null, "English - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4618), null, 1 },
                    { 1031, 104, "Islamic for Grade 4", null, "Islamic - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4621), null, 1 },
                    { 1032, 104, "Social Studies for Grade 4", null, "Social Studies - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4623), null, 1 },
                    { 1033, 104, "Computer for Grade 4", null, "Computer - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4626), null, 1 },
                    { 1034, 104, "Physical Education for Grade 4", null, "Physical Education - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4628), null, 1 },
                    { 1035, 104, "Art for Grade 4", null, "Art - Grade 4", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4630), null, 1 },
                    { 1036, 105, "Arabic for Grade 5", null, "Arabic - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4632), null, 1 },
                    { 1037, 105, "Mathematics for Grade 5", null, "Mathematics - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4634), null, 1 },
                    { 1038, 105, "Science for Grade 5", null, "Science - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4636), null, 1 },
                    { 1039, 105, "English for Grade 5", null, "English - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4639), null, 1 },
                    { 1040, 105, "Islamic for Grade 5", null, "Islamic - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4641), null, 1 },
                    { 1041, 105, "Social Studies for Grade 5", null, "Social Studies - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4643), null, 1 },
                    { 1042, 105, "Computer for Grade 5", null, "Computer - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4652), null, 1 },
                    { 1043, 105, "Physical Education for Grade 5", null, "Physical Education - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4654), null, 1 },
                    { 1044, 105, "Art for Grade 5", null, "Art - Grade 5", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4656), null, 1 },
                    { 1045, 106, "Arabic for Grade 6", null, "Arabic - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4658), null, 1 },
                    { 1046, 106, "Mathematics for Grade 6", null, "Mathematics - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4660), null, 1 },
                    { 1047, 106, "Science for Grade 6", null, "Science - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4662), null, 1 },
                    { 1048, 106, "English for Grade 6", null, "English - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4664), null, 1 },
                    { 1049, 106, "Islamic for Grade 6", null, "Islamic - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4666), null, 1 },
                    { 1050, 106, "Social Studies for Grade 6", null, "Social Studies - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4668), null, 1 },
                    { 1051, 106, "Computer for Grade 6", null, "Computer - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4670), null, 1 },
                    { 1052, 106, "Physical Education for Grade 6", null, "Physical Education - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4673), null, 1 },
                    { 1053, 106, "Art for Grade 6", null, "Art - Grade 6", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4674), null, 1 },
                    { 1054, 107, "Arabic for Grade 7", null, "Arabic - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4676), null, 1 },
                    { 1055, 107, "Mathematics for Grade 7", null, "Mathematics - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4678), null, 1 },
                    { 1056, 107, "Science for Grade 7", null, "Science - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4680), null, 1 },
                    { 1057, 107, "English for Grade 7", null, "English - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4682), null, 1 },
                    { 1058, 107, "Islamic for Grade 7", null, "Islamic - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4684), null, 1 },
                    { 1059, 107, "Social Studies for Grade 7", null, "Social Studies - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4686), null, 1 },
                    { 1060, 107, "Computer for Grade 7", null, "Computer - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4688), null, 1 },
                    { 1061, 107, "Physical Education for Grade 7", null, "Physical Education - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4690), null, 1 },
                    { 1062, 107, "Art for Grade 7", null, "Art - Grade 7", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4693), null, 1 },
                    { 1063, 108, "Arabic for Grade 8", null, "Arabic - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4695), null, 1 },
                    { 1064, 108, "Mathematics for Grade 8", null, "Mathematics - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4696), null, 1 },
                    { 1065, 108, "Science for Grade 8", null, "Science - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4705), null, 1 },
                    { 1066, 108, "English for Grade 8", null, "English - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4707), null, 1 },
                    { 1067, 108, "Islamic for Grade 8", null, "Islamic - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4709), null, 1 },
                    { 1068, 108, "Social Studies for Grade 8", null, "Social Studies - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4711), null, 1 },
                    { 1069, 108, "Computer for Grade 8", null, "Computer - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4713), null, 1 },
                    { 1070, 108, "Physical Education for Grade 8", null, "Physical Education - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4715), null, 1 },
                    { 1071, 108, "Art for Grade 8", null, "Art - Grade 8", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4717), null, 1 },
                    { 1072, 109, "Arabic for Grade 9", null, "Arabic - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4719), null, 1 },
                    { 1073, 109, "Mathematics for Grade 9", null, "Mathematics - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4721), null, 1 },
                    { 1074, 109, "Science for Grade 9", null, "Science - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4723), null, 1 },
                    { 1075, 109, "English for Grade 9", null, "English - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4725), null, 1 },
                    { 1076, 109, "Islamic for Grade 9", null, "Islamic - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4727), null, 1 },
                    { 1077, 109, "Social Studies for Grade 9", null, "Social Studies - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4730), null, 1 },
                    { 1078, 109, "Computer for Grade 9", null, "Computer - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4731), null, 1 },
                    { 1079, 109, "Physical Education for Grade 9", null, "Physical Education - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4733), null, 1 },
                    { 1080, 109, "Art for Grade 9", null, "Art - Grade 9", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4735), null, 1 },
                    { 1081, 110, "Arabic for Grade 10", null, "Arabic - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4738), null, 1 },
                    { 1082, 110, "Mathematics for Grade 10", null, "Mathematics - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4740), null, 1 },
                    { 1083, 110, "Science for Grade 10", null, "Science - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4742), null, 1 },
                    { 1084, 110, "English for Grade 10", null, "English - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4744), null, 1 },
                    { 1085, 110, "Islamic for Grade 10", null, "Islamic - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4746), null, 1 },
                    { 1086, 110, "Social Studies for Grade 10", null, "Social Studies - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4748), null, 1 },
                    { 1087, 110, "Computer for Grade 10", null, "Computer - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4750), null, 1 },
                    { 1088, 110, "Physical Education for Grade 10", null, "Physical Education - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4752), null, 1 },
                    { 1089, 110, "Art for Grade 10", null, "Art - Grade 10", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4755), null, 1 },
                    { 1090, 111, "Arabic for Grade 11", null, "Arabic - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4757), null, 1 },
                    { 1091, 111, "Mathematics for Grade 11", null, "Mathematics - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4760), null, 1 },
                    { 1092, 111, "Science for Grade 11", null, "Science - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4768), null, 1 },
                    { 1093, 111, "English for Grade 11", null, "English - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4770), null, 1 },
                    { 1094, 111, "Islamic for Grade 11", null, "Islamic - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4772), null, 1 },
                    { 1095, 111, "Social Studies for Grade 11", null, "Social Studies - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4774), null, 1 },
                    { 1096, 111, "Computer for Grade 11", null, "Computer - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4777), null, 1 },
                    { 1097, 111, "Physical Education for Grade 11", null, "Physical Education - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4779), null, 1 },
                    { 1098, 111, "Art for Grade 11", null, "Art - Grade 11", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4781), null, 1 },
                    { 1099, 112, "Arabic for Grade 12", null, "Arabic - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4783), null, 1 },
                    { 1100, 112, "Mathematics for Grade 12", null, "Mathematics - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4785), null, 1 },
                    { 1101, 112, "Science for Grade 12", null, "Science - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4787), null, 1 },
                    { 1102, 112, "English for Grade 12", null, "English - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4789), null, 1 },
                    { 1103, 112, "Islamic for Grade 12", null, "Islamic - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4791), null, 1 },
                    { 1104, 112, "Social Studies for Grade 12", null, "Social Studies - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4793), null, 1 },
                    { 1105, 112, "Computer for Grade 12", null, "Computer - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4795), null, 1 },
                    { 1106, 112, "Physical Education for Grade 12", null, "Physical Education - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4797), null, 1 },
                    { 1107, 112, "Art for Grade 12", null, "Art - Grade 12", new DateTime(2025, 12, 6, 20, 22, 3, 672, DateTimeKind.Local).AddTicks(4799), null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_SupervisorId",
                table: "Activities",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CurriculumId",
                table: "Courses",
                column: "CurriculumId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentLevelLevelId",
                table: "Courses",
                column: "StudentLevelLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Curriculums_LevelId",
                table: "Curriculums",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LocationId",
                table: "Employees",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CountryId",
                table: "Locations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_LocationId",
                table: "Parents",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseEnrollments_CourseId",
                table: "StudentCourseEnrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_CourseId",
                table: "StudentGrades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LevelId",
                table: "Students",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LocationId",
                table: "Students",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LocationId1",
                table: "Students",
                column: "LocationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_LocationId",
                table: "Teachers",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "StudentCourseEnrollments");

            migrationBuilder.DropTable(
                name: "StudentGrades");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Curriculums");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "StudentLevels");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
