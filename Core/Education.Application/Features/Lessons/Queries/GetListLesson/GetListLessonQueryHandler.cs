using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Lessons.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Lessons.Queries.GetListCourse
{
    public class GetListLessonQueryHandler : IRequestHandler<GetListLessonQuery, LessonListModel>
    {
        private readonly IMapper _mapper;
        private readonly ILessonRepository _lessonRepository;

        public GetListLessonQueryHandler(IMapper mapper, ILessonRepository lessonRepository)
        {
            _mapper = mapper;
            _lessonRepository = lessonRepository;
        }

        public async Task<LessonListModel> Handle(GetListLessonQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Lesson> lessons = await _lessonRepository.GetListAsync(
                include: l => l.Include(l => l.Course),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize);

            LessonListModel mappedModel = _mapper.Map<LessonListModel>(lessons);
            return mappedModel;
        }
    }
}
