using AutoMapper;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, UpdateCourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly CourseBusinessRules _courseBusinessRules;
        private readonly IMapper _mapper;

        public UpdateCourseCommandHandler(ICourseRepository courseRepository, CourseBusinessRules courseBusinessRules, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _courseBusinessRules = courseBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdateCourseDto> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            await _courseBusinessRules.CourseNameCanNotDuplicatedWhenInserted(request.Name);
            _courseBusinessRules.ShouldHaveValidId(request.Id);

            Course? courseToUpdate = await _courseRepository.GetAsync(c => c.Id == request.Id);
            Course mappedCourse = _mapper.Map(request, courseToUpdate);
            Course updatedCourse = await _courseRepository.UpdateAsync(mappedCourse);
            UpdateCourseDto updateCourseDto = _mapper.Map<UpdateCourseDto>(updatedCourse);

            return updateCourseDto;
            
        }
    }
}
