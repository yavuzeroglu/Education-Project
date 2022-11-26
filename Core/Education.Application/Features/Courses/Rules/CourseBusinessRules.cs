using Core.CrossCuttingConcerns.Exceptions;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Features.Courses.Rules
{
    public class CourseBusinessRules
    {
        private readonly ICourseRepository _courseRepository;
        public CourseBusinessRules(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;   
        }

        public async Task CourseNameCanNotDuplicatedWhenInserted(string courseName)
        {
            var course = await _courseRepository.GetListAsync(c => c.Name == courseName);
            if (course.Items.Any()) 
                throw new BusinessException($"{courseName} course exist");
        }

        public void CourseShouldExistWhenRequest(Course course)
        {
            if (course is null) 
                throw new BusinessException("Requested course does not exist");
        }

        public void ShouldHaveValidId(int courseId)
        {
            Course result = _courseRepository.Get(c => c.Id == courseId);
            if (result is null)
                throw new BusinessException("Course's Id is not found!");
        }

    }
}
