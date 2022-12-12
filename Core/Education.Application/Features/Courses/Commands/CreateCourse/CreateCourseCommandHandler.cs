using AutoMapper;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Education.Application.Features.Courses.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CreateCourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly CourseBusinessRules _courseBusinessRules;
        private readonly ILogger<CreateCourseCommandHandler> _logger;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper, CourseBusinessRules courseBusinessRules, ILogger<CreateCourseCommandHandler> logger)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
            _logger = logger;
        }

        public async Task<CreateCourseDto> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            await _courseBusinessRules.CourseNameCanNotDuplicatedWhenInserted(request.Name);
            Course mappedCourse = _mapper.Map<Course>(request);
            Course createdCourse = await _courseRepository.AddAsync(mappedCourse);
            CreateCourseDto createCourseDto = _mapper.Map<CreateCourseDto>(createdCourse);
            _logger.LogInformation("Kurs Eklendi");
            return createCourseDto;

        }
    }
}
