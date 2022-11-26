using Core.Application.Pipelines.Validation;
using Education.Application.Features.Courses.Rules;
using Education.Application.Features.Lessons.Rules;
using Education.Application.Features.Students.Rules;
using Education.Application.Features.Subjects.Rules;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Education.Application
{
    public static class ApplicationServiceRegistration 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<StudentBusinessRules>();
            services.AddScoped<CourseBusinessRules>();
            services.AddScoped<LessonBusinessRules>();
            services.AddScoped<SubjectBusinessRules>();
            //services.AddScpoed<LessonBusinessRules>();


            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            
            
            return services;
        }
    }
}
