using AutoMapper;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Courses.Commands.DeleteCourse
{
    public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, DeleteCourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly CourseBusinessRules _courseBusinessRules;

        public DeleteCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper, CourseBusinessRules courseBusinessRules)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }

        public async Task<DeleteCourseDto> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetAsync(c => c.Id == request.Id);
            _courseBusinessRules.CourseShouldExistWhenRequest(course);

            
            Course deletedCourse = await _courseRepository.DeleteAsync(course);
            var deleteCourseDto = _mapper.Map<DeleteCourseDto>(deletedCourse);

            return deleteCourseDto;
        }
    }
}
