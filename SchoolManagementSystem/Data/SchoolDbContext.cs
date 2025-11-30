using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data
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


        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Curriculum> Curriculum { get; set; } // the best practice is the plural name (curriculums)
        public DbSet<Activity> Activities { get; set; }
        public DbSet<StudentCouseEnrollment> StudentCouseEnrollment { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
        public DbSet<Attendance> Attendance { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Add a student in a course (composite key)
            modelBuilder.Entity<StudentCouseEnrollment>()
                .HasKey(sce => new { sce.StudentId, sce.CourseId });

            //  Relation between StudentCouseEnrollment and Course
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



            //Student's grades
            modelBuilder.Entity<StudentGrade>()
                .HasKey(sg => new { sg.StudentId, sg.CourseId , sg.ExamType });


            // تحديد العلاقة بين StudentGrade و Course
            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Course)
                .WithMany(c => c.Grades)
                .HasForeignKey(sg => sg.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // تحديد العلاقة بين StudentGrade و Student
            modelBuilder.Entity<StudentGrade>()
                .HasOne(sg => sg.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Restrict);


            //Attendance
            modelBuilder.Entity<Attendance>()
                .HasKey(a => new { a.PersonId, a.PersonType, a.AttendanceDate });

            
            //Deleting 

            modelBuilder.Entity<Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            //Location - City
            modelBuilder.Entity<Location>()
                .HasOne(l => l.City)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            //Student - Location
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Location)
                .WithMany(l => l.Students)
                .HasForeignKey(s => s.LocationId)
                .OnDelete(DeleteBehavior.Restrict);
            //Student - Parent
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(s => s.ParentId)
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
                .WithMany() // 
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


            base.OnModelCreating(modelBuilder);

        }

    }
}
