using Education.Application.Abstractions.Services.Auth;
using Education.Application.Abstractions.Services.Users;
using Education.Application.Services.Repositories;
using Education.Domain.Entities.Identity;
using Education.Persistance.Contexts;
using Education.Persistance.Repositories;
using Education.Persistance.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Education.Persistance
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<EducationDbContext>(opt => opt.UseSqlServer(ConfigurationHelper.ConnectionString));

            services.AddIdentity<AppUser, AppRole>(opt =>
            {
                opt.Password.RequiredLength = 3;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireUppercase= false;

                //opt.User.AllowedUserNameCharacters =  "abcçdefghiıjklmnoöpqrsştuüvwxyzABCÇDEFGHIİJKLMNOÖPQRSŞTUÜVWXYZ0123456789-._@+";
                opt.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<EducationDbContext>();


            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<ISubjectImageFileRepository, SubjectImageFileRepository>();
            services.AddScoped<IDocumentFileRepository, DocumentFileRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
