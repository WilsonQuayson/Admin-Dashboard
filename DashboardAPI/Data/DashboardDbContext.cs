using DashboardAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DashboardAPI.Data
{
    public class DashboardDbContext(DbContextOptions<DashboardDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students => Set<Student>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    DateOfBirth = new DateTime(2000, 5, 15),
                    Performance = 85
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    DateOfBirth = new DateTime(1999, 8, 20),
                    Performance = 92
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Emily",
                    LastName = "Johnson",
                    Email = "emily.johnson@example.com",
                    DateOfBirth = new DateTime(2001, 2, 10),
                    Performance = 78
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    DateOfBirth = new DateTime(1998, 12, 5),
                    Performance = 88
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Sophia",
                    LastName = "Davis",
                    Email = "sophia.davis@example.com",
                    DateOfBirth = new DateTime(2002, 7, 30),
                    Performance = 95
                }
            );
        }
    }
}
