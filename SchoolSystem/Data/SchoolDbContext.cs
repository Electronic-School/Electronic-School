using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Data
{
    public class SchoolDbContext : DbContext
    {
        private const string ConnectionString = "Server=.; Database=SchoolManagementDB; Trusted_Connection=True; Integrated Security=True; TrustServerCertificate=True; MultipleActiveResultSets=true;";

        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

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
        public DbSet<StudentCouseEnrollment> StudentCouseEnrollments { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // تسمية الجداول
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Parent>().ToTable("Parents");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<Curriculum>().ToTable("Curriculum");
            modelBuilder.Entity<StudentLevel>().ToTable("StudentLevel");
            modelBuilder.Entity<Activity>().ToTable("Activities");
            modelBuilder.Entity<StudentCouseEnrollment>().ToTable("StudentCouseEnrollment");
            modelBuilder.Entity<StudentGrade>().ToTable("StudentGrades");
            modelBuilder.Entity<Attendance>().ToTable("Attendances");

            // StudentCouseEnrollment (composite key)
            modelBuilder.Entity<StudentCouseEnrollment>()
                .HasKey(sce => new { sce.StudentId, sce.CourseId });

            // علاقات StudentCouseEnrollment
            modelBuilder.Entity<StudentCouseEnrollment>()
               .HasOne(sce => sce.Course)
               .WithMany(c => c.StudentEnrollments)
               .HasForeignKey(sce => sce.CourseId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentCouseEnrollment>()
                .HasOne(sce => sce.Student)
                .WithMany(s => s.StudentEnrollments)
                .HasForeignKey(sce => sce.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student - StudentLevel
            modelBuilder.Entity<Student>()
                .HasOne(s => s.StudentLevel)
                .WithMany(sl => sl.Students)
                .HasForeignKey(s => s.LevelId)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentGrade (composite key)
            modelBuilder.Entity<StudentGrade>()
                .HasKey(sg => new { sg.StudentId, sg.CourseId, sg.ExamType });

            // علاقات StudentGrade
            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Course)
                .WithMany(c => c.Grades)
                .HasForeignKey(sg => sg.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Attendance
            modelBuilder.Entity<Attendance>()
                .HasKey(a => a.AttendanceId);

            // Location - Country
            modelBuilder.Entity<Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Location - City
            modelBuilder.Entity<Location>()
                .HasOne(l => l.City)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student - Location
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Location)
                .WithMany(l => l.Students)
                .HasForeignKey(s => s.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student - Parent
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher - Location
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Location)
                .WithMany(l => l.Teachers)
                .HasForeignKey(t => t.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee - Location
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.LOcation)
                .WithMany(l => l.Employees)
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Activity - Employee (Supervisor)
            modelBuilder.Entity<Activity>()
                .HasOne(a => a.Supervisor)
                .WithMany()
                .HasForeignKey(a => a.SupervisorId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);

            // Course - Teacher
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Course - Curriculum
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Curriculum)
                .WithMany(curr => curr.Courses)
                .HasForeignKey(c => c.CurriculumId)
                .OnDelete(DeleteBehavior.Restrict);

            //// Course - StudentLevel (التعديل المطلوب)
            //modelBuilder.Entity<Course>()
            //    .HasOne(c => c.StudentLevel)
            //    .WithMany(sl => sl.Courses)
            //    .HasForeignKey(c => c.LevelId)
            //    .OnDelete(DeleteBehavior.Restrict);

            // Curriculum - StudentLevel
            modelBuilder.Entity<Curriculum>()
                .HasOne(c => c.StudentLevel)
                .WithMany(sl => sl.Curriculums)
                .HasForeignKey(c => c.LevelId)
                .OnDelete(DeleteBehavior.Restrict);

            // إضافة القيود والافتراضات
            modelBuilder.Entity<Student>()
                .Property(s => s.DateOfBirth)
                .IsRequired(false);

            modelBuilder.Entity<StudentCouseEnrollment>()
                .Property(sce => sce.EnrollmentDate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired(false);

            modelBuilder.Entity<Attendance>()
                .Property(a => a.AttendanceDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .Property(c => c.StartDate)
                .HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Course>()
            //    .Property(c => c.IsActive)
            //    .HasDefaultValue(true);

            // إضافة قيود CHECK للمتطلبات
            modelBuilder.Entity<Attendance>()
                .HasCheckConstraint("CK_Attendance_PersonType",
                    "[PersonType] IN ('Student', 'Teacher', 'Emp')");

            modelBuilder.Entity<Attendance>()
                .HasCheckConstraint("CK_Attendance_AttendanceStatus",
                    "[AttendanceStatus] IN ('Present', 'Absent', 'Late', 'Excused')");

            modelBuilder.Entity<StudentLevel>()
                .HasCheckConstraint("CK_StudentLevel_Stage",
                    "[Stage] IN ('ابتدائي', 'أساسي', 'ثانوي')");

            // إضافة قيد CHECK للتواريخ في Course
            modelBuilder.Entity<Course>()
                .HasCheckConstraint("CK_Course_Dates",
                    "[StartDate] <= [EndDate] OR [StartDate] IS NULL OR [EndDate] IS NULL");

            base.OnModelCreating(modelBuilder);
        }
    }
}