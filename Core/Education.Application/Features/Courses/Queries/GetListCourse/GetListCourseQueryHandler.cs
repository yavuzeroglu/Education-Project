using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Courses.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Courses.Queries.GetListCourse
{
    public class GetListCourseQueryHandler : IRequestHandler<GetListCourseQuery, CourseListModel>
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        //private readonly CourseBusinessRules _courseBusinessRules;

        public GetListCourseQueryHandler(IMapper mapper, ICourseRepository courseRepository)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
        }
        public async Task<CourseListModel> Handle(GetListCourseQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Course> courses = await _courseRepository.GetListAsync
                (
                    include: c => c.Include(c => c.Lessons),
                    index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize
                );

            CourseListModel mappedCourse = _mapper.Map<CourseListModel>(courses);

            return mappedCourse;
        }
    }
}
