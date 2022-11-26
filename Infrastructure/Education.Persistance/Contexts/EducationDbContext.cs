using Core.Persistance.Repositories;
using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Education.Persistance.Contexts
{
    public class EducationDbContext : DbContext
    {


        public EducationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }


        
        
    }
}
