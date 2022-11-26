using AutoMapper;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CreateCourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly CourseBusinessRules _courseBusinessRules;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper, CourseBusinessRules courseBusinessRules)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }

        public async Task<CreateCourseDto> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            await _courseBusinessRules.CourseNameCanNotDuplicatedWhenInserted(request.Name);
            Course mappedCourse = _mapper.Map<Course>(request);
            Course createdCourse = await _courseRepository.AddAsync(mappedCourse);
            CreateCourseDto createCourseDto = _mapper.Map<CreateCourseDto>(createdCourse);

            return createCourseDto;

        }
    }
}
