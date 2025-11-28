using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Country> Countrys { get; set; }
    public DbSet<City> Citis{ get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=SCHOOLMANAGEMENTDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
