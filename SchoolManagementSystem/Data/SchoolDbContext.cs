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

            // Add a student in acourse
            modelBuilder.Entity<StudentCouseEnrollment>()
                .HasKey(sce => new { sce.StudentId, sce.CourseId });

            //Student's grades
            modelBuilder.Entity<StudentGrade>()
                .HasKey(sg => new { sg.StudentId, sg.CourseId });

            //Attendance
            modelBuilder.Entity<Attendance>()
                .HasKey(a => new { a.PersonId, a.PersonType, a.AttendanceDate });

            
            //Deleting 

            modelBuilder.Entity<Location>()
                .HasOne(l => l.Country)
                .WithMany(c => c.Locations)
                .HasForeignKey(l => l.CountryId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Student>()
                .HasOne(s => s.Location)
                .WithMany(l => l.Students)
                .HasForeignKey(s => s.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Parent)
                .WithMany(p => p.Children)
                .HasForeignKey(s => s.ParentId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);

        }

    }
}
