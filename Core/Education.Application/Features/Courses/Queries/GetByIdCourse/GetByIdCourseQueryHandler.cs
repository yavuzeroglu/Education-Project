using AutoMapper;
using Education.Application.Features.Courses.DTOs;
using Education.Application.Features.Courses.Rules;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Courses.Queries.GetByIdCourse
{
    public class GetByIdCourseQueryHandler : IRequestHandler<GetByIdCourseQuery, GetByIdCourseDto>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly CourseBusinessRules _courseBusinessRules;

        public GetByIdCourseQueryHandler(ICourseRepository courseRepository, IMapper mapper, CourseBusinessRules courseBusinessRules)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseBusinessRules = courseBusinessRules;
        }

        public async Task<GetByIdCourseDto> Handle(GetByIdCourseQuery request, CancellationToken cancellationToken)
        {
            Course? course = await _courseRepository.GetAsync(c => c.Id == request.Id);
            _courseBusinessRules.CourseShouldExistWhenRequest(course);

            GetByIdCourseDto getByIdCourseDto = _mapper.Map<GetByIdCourseDto>(course);
            return getByIdCourseDto;
        }
    }
}
