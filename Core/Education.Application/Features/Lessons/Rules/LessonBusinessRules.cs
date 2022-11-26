using Core.CrossCuttingConcerns.Exceptions;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Features.Lessons.Rules
{
    public class LessonBusinessRules
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonBusinessRules(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task CourseNameCanNotDuplicatedWhenInserted(string lessonName)
        {
            var lesson = await _lessonRepository.GetListAsync(l => l.Name == lessonName);
            if (lesson.Items.Any())
                throw new BusinessException($"{lessonName} lesson exist");
        }

        public void CourseShouldExistWhenRequest(Lesson lesson)
        {
            if (lesson is null)
                throw new BusinessException("Requested course does not exist");
        }

        public void ShouldHaveValidId(int lessonId)
        {
            var result = _lessonRepository.Get(l => l.Id == lessonId);
            if (result is null)
                throw new BusinessException("Lesson's Id is not found.");
        }
    }
}
