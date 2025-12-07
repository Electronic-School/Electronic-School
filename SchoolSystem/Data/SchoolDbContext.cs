using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolSystem.Data
{
    public class SchoolDbContext : DbContext
    {

        private const string ConnectionString = "Server=.; Database=TariqBenZiadSchoolManagementDB; Trusted_Connection=True; Integrated Security=True; TrustServerCertificate=True; MultipleActiveResultSets=true;";

        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<StudentLevel> StudentLevels { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<StudentCourseEnrollment> StudentCourseEnrollments { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString, sqlOptions =>
                {
                    optionsBuilder.UseSqlServer(ConnectionString);
                });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table names (optional, for clarity)
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Parent>().ToTable("Parents");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Curriculum>().ToTable("Curriculums");
            modelBuilder.Entity<StudentLevel>().ToTable("StudentLevels");
            modelBuilder.Entity<Activity>().ToTable("Activities");
            modelBuilder.Entity<StudentCourseEnrollment>().ToTable("StudentCourseEnrollments");
            modelBuilder.Entity<StudentGrade>().ToTable("StudentGrades");
            modelBuilder.Entity<Attendance>().ToTable("Attendances");

            // Composite keys
            modelBuilder.Entity<StudentCourseEnrollment>()
                .HasKey(sce => new { sce.StudentId, sce.CourseId });

            modelBuilder.Entity<StudentGrade>()
                .HasKey(sg => new { sg.StudentId, sg.CourseId, sg.ExamType });

            // Relationships
            // Student - StudentLevel
            modelBuilder.Entity<Student>()
                .HasOne(s => s.StudentLevel)
                .WithMany(sl => sl.Students)
                .HasForeignKey(s => s.LevelId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student - Parent
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student - Location
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Location)
                .WithMany(l => l.Students )
                .HasForeignKey(s => s.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Parent - Location
            modelBuilder.Entity<Parent>()
                .HasOne(p => p.Location)
                .WithMany(l => l.Parents)
                .HasForeignKey(p => p.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Location - Country
            modelBuilder.Entity<Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher - Location (optional)
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Location)
                .WithMany(l => l.Teachers)
                .HasForeignKey(t => t.LocationId)
                .OnDelete(DeleteBehavior.SetNull);

            // Employee - Location (optional)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Location)
                .WithMany(l => l.Employees)
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.SetNull);

            // Activity - Employee (Supervisor) optional
            modelBuilder.Entity<Activity>()
                .HasOne(a => a.Supervisor)
                .WithMany(e => e.ActivitiesSupervised)
                .HasForeignKey(a => a.SupervisorId)
                .OnDelete(DeleteBehavior.SetNull);

            // Course - Curriculum
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Curriculum)
                .WithMany(curr => curr.Courses)
                .HasForeignKey(c => c.CurriculumId)
                .OnDelete(DeleteBehavior.Restrict);

            // Course - Teacher (optional)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // StudentCourseEnrollment relations
            modelBuilder.Entity<StudentCourseEnrollment>()
                .HasOne(sce => sce.Student)
                .WithMany(s => s.StudentEnrollments)
                .HasForeignKey(sce => sce.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentCourseEnrollment>()
                .HasOne(sce => sce.Course)
                .WithMany(c => c.StudentEnrollments)
                .HasForeignKey(sce => sce.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentGrade relations
            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Course)
                .WithMany(c => c.Grades)
                .HasForeignKey(sg => sg.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Defaults and constraints
            modelBuilder.Entity<StudentCourseEnrollment>()
                .Property(sce => sce.EnrollmentDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Attendance>()
                .Property(a => a.AttendanceDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .Property(c => c.StartDate)
                .HasDefaultValueSql("GETDATE()");

            // Check constraints
            modelBuilder.Entity<Attendance>()
                .HasCheckConstraint("CK_Attendance_PersonType", "[PersonType] IN ('Student','Teacher','Employee')");

            modelBuilder.Entity<Attendance>()
                .HasCheckConstraint("CK_Attendance_Status", "[AttendanceStatus] IN ('Present','Absent','Late','Excused')");

            modelBuilder.Entity<StudentLevel>()
                .HasCheckConstraint("CK_StudentLevel_Stage", "[Stage] IN (N'ابتدائي', N'أساسي', N'ثانوي')");

            modelBuilder.Entity<Course>()
                .HasCheckConstraint("CK_Course_Dates", "[StartDate] <= [EndDate] OR [StartDate] IS NULL OR [EndDate] IS NULL");

            // ---------- Seed data (countries, cities, levels, curricula, sample teacher, courses) ----------
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = 1, CountryCode = "SAU", CountryName = "Saudi Arabia" },
                new Country { CountryId = 2, CountryCode = "ARE", CountryName = "United Arab Emirates" },
                new Country { CountryId = 3, CountryCode = "OMN", CountryName = "Oman" },
                new Country { CountryId = 4, CountryCode = "QAT", CountryName = "Qatar" },
                new Country { CountryId = 5, CountryCode = "BHR", CountryName = "Bahrain" },
                new Country { CountryId = 6, CountryCode = "KWT", CountryName = "Kuwait" },
                new Country { CountryId = 7, CountryCode = "YEM", CountryName = "Yemen" }
            );

            // Cities (CountryCode only, not FK)
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityCode = "SA-RYD", CityName = "Riyadh", CountryCode = "SAU" },
                new City { CityId = 2, CityCode = "SA-JED", CityName = "Jeddah", CountryCode = "SAU" },
                new City { CityId = 3, CityCode = "AE-AUH", CityName = "Abu Dhabi", CountryCode = "ARE" },
                new City { CityId = 4, CityCode = "AE-DXB", CityName = "Dubai", CountryCode = "ARE" },
                new City { CityId = 5, CityCode = "OM-MSC", CityName = "Muscat", CountryCode = "OMN" },
                new City { CityId = 6, CityCode = "QA-DOH", CityName = "Doha", CountryCode = "QAT" },
                new City { CityId = 7, CityCode = "BH-MNL", CityName = "Manama", CountryCode = "BHR" },
                new City { CityId = 8, CityCode = "KW-KWI", CityName = "Kuwait City", CountryCode = "KWT" },
                new City { CityId = 9, CityCode = "YE-SAN", CityName = "Sana'a", CountryCode = "YEM" },
                new City { CityId = 10, CityCode = "YE-ADN", CityName = "Aden", CountryCode = "YEM" }
            );
            //

            // Student levels 1..12
            var levels = Enumerable.Range(1, 12).Select(i => new StudentLevel
            {
                LevelId = i,
                LevelName = $"Grade {i}",
                LevelNumber = i,
                Stage = i <= 6 ? "ابتدائي" : (i <= 9 ? "أساسي" : "ثانوي")
            }).ToArray();
            modelBuilder.Entity<StudentLevel>().HasData(levels);


            // Seed a sample location (used for teacher seed)
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, CountryId = 1, CityId = 1, Street = "Default St", BuildingNo = "1" }
            );

            modelBuilder.Entity<Teacher>().HasData(
    new Teacher
    {
        TeacherId = 1,
        FirstName = "Ali",
        LastName = "Ahmed",
        Email = "ali.ahmed@school.com",
        DateOfBirth = new DateTime(1985, 5, 10),
        StartWorkingDate = new DateTime(2020, 9, 1),
        LocationId = 1,
        PhoneNumber = "555123456",
        Salary = 4000.00m 
    }
);

            // Curriculums (one per level)
            var curricula = Enumerable.Range(1, 12).Select(i => new Curriculum
            {
                CurriculumId = 100 + i,
                Name = $"Yemeni Curriculum Grade {i}",
                Description = $"Basic Yemeni curriculum for Grade {i}",
                LevelId = i,
                Semester = "First"
            }).ToArray();
            modelBuilder.Entity<Curriculum>().HasData(curricula);

            // Courses per level (basic set)
            var subjects = new[] { "Arabic", "Mathematics", "Science", "English", "Islamic", "Social Studies", "Computer", "Physical Education", "Art" };
            var courseSeeds = new List<Course>();
            int courseId = 1000;
            foreach (var lvl in Enumerable.Range(1, 12))
            {
                foreach (var subj in subjects)
                {
                    courseSeeds.Add(new Course
                    {
                        CourseId = courseId++,
                        Name = $"{subj} - Grade {lvl}",
                        Description = $"{subj} for Grade {lvl}",
                        StartDate = DateTime.Now,
                        CurriculumId = 100 + lvl,
                        TeacherId = 1
                    });
                }
            }
            modelBuilder.Entity<Course>().HasData(courseSeeds.ToArray());

            base.OnModelCreating(modelBuilder);
        }
    }
}
