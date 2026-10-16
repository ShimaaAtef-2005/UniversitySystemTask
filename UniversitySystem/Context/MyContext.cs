
using Microsoft.EntityFrameworkCore;
using UniversitySystem.Models;

namespace UniversitySystem.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Subject)
                .WithOne(s => s.Teacher)
                .HasForeignKey<Subject>(s => s.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects)
                .WithMany(s => s.Students);

            // Universities
            modelBuilder.Entity<University>().HasData(
                new University
                {
                    UniversityId = 1,
                    Name = "Sohag University",
                    Address = "Sohag, Egypt"
                }
            );

            // Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherId = 1,
                    Name = "Ahmed Mohamed",
                    Email = "ahmed@university.com",
                    PhoneNumber = "01012345678",
                    Salary = 15000,
                    UniversityId = 1
                },
                new Teacher
                {
                    TeacherId = 2,
                    Name = "Mona Ali",
                    Email = "mona@university.com",
                    PhoneNumber = "01012345679",
                    Salary = 18000,
                    UniversityId = 1
                },
                new Teacher
                {
                    TeacherId = 3,
                    Name = "Mahmoud Hassan",
                    Email = "mahmoud@university.com",
                    PhoneNumber = "01012345680",
                    Salary = 17000,
                    UniversityId = 1
                }
            );

            // Subjects
            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    Name = "C# Programming",
                    CreditsHours = 3,
                    TeacherId = 1
                },
                new Subject
                {
                    SubjectId = 2,
                    Name = "Database Systems",
                    CreditsHours = 4,
                    TeacherId = 2
                },
                new Subject
                {
                    SubjectId = 3,
                    Name = "Web Development",
                    CreditsHours = 3,
                    TeacherId = 3
                }
            );

            // Students
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Ali Hassan",
                    Email = "ali@student.com",
                    PhoneNumber = "01112345678",
                    DateOfBirth = new DateTime(2005, 5, 10),
                    UniversityId = 1
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Sara Ahmed",
                    Email = "sara@student.com",
                    PhoneNumber = "01112345679",
                    DateOfBirth = new DateTime(2004, 8, 15),
                    UniversityId = 1
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Omar Khaled",
                    Email = "omar@student.com",
                    PhoneNumber = "01112345680",
                    DateOfBirth = new DateTime(2005, 2, 20),
                    UniversityId = 1
                }
            );







        }
    }
}
