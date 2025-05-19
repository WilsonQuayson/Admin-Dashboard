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
                    Performance = 55
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    DateOfBirth = new DateTime(1999, 8, 20),
                    Performance = 72
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Emily",
                    LastName = "Johnson",
                    Email = "emily.johnson@example.com",
                    DateOfBirth = new DateTime(2001, 2, 10),
                    Performance = 20
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Michael",
                    LastName = "Brown",
                    Email = "michael.brown@example.com",
                    DateOfBirth = new DateTime(1998, 12, 5),
                    Performance = 85
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Sophia",
                    LastName = "Davis",
                    Email = "sophia.davis@example.com",
                    DateOfBirth = new DateTime(2002, 7, 30),
                    Performance = 95
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Liam",
                    LastName = "Wilson",
                    Email = "liam.wilson@example.com",
                    DateOfBirth = new DateTime(2001, 4, 25),
                    Performance = 37
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Olivia",
                    LastName = "Taylor",
                    Email = "olivia.taylor@example.com",
                    DateOfBirth = new DateTime(2003, 9, 14),
                    Performance = 70
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "William",
                    LastName = "Moore",
                    Email = "william.moore@example.com",
                    DateOfBirth = new DateTime(1997, 11, 8),
                    Performance = 65
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Isabella",
                    LastName = "Anderson",
                    Email = "isabella.anderson@example.com",
                    DateOfBirth = new DateTime(2000, 3, 17),
                    Performance = 89
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "James",
                    LastName = "Harris",
                    Email = "james.harris@example.com",
                    DateOfBirth = new DateTime(1999, 6, 12),
                    Performance = 87
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Charlotte",
                    LastName = "Clark",
                    Email = "charlotte.clark@example.com",
                    DateOfBirth = new DateTime(2002, 1, 22),
                    Performance = 93
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Benjamin",
                    LastName = "Martinez",
                    Email = "benjamin.martinez@example.com",
                    DateOfBirth = new DateTime(1998, 10, 19),
                    Performance = 52
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Amelia",
                    LastName = "Garcia",
                    Email = "amelia.garcia@example.com",
                    DateOfBirth = new DateTime(2001, 5, 9),
                    Performance = 94
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Elijah",
                    LastName = "Rodriguez",
                    Email = "elijah.rodriguez@example.com",
                    DateOfBirth = new DateTime(1999, 12, 1),
                    Performance = 41
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Mia",
                    LastName = "Martins",
                    Email = "mia.martins@example.com",
                    DateOfBirth = new DateTime(2003, 8, 28),
                    Performance = 97
                }
            );
        }
    }
}
