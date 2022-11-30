using Education.Application.Services.Repositories;
using Education.Persistance.Contexts;
using Education.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Education.Persistance
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<EducationDbContext>(opt => opt.UseSqlServer(ConfigurationHelper.ConnectionString));

            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();  
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<ISubjectImageFileRepository, SubjectImageFileRepository>();
            services.AddScoped<IDocumentFileRepository, DocumentFileRepository>();

            return services;
        }
    }
}
