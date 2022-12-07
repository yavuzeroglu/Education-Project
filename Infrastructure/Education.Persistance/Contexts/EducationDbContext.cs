using Education.Domain.Entities;
using Education.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Education.Persistance.Contexts
{
    public class EducationDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EducationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Domain.Entities.File> Files { get; set; }
        public DbSet<DocumentFile> DocumentFiles { get; set; }
        public DbSet<SubjectImageFile> SubjectImageFiles { get; set; }





    }
}
