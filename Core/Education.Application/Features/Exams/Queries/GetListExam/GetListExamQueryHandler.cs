using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Exams.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Exams.Queries.GetListExam
{
    public class GetListExamQueryHandler : IRequestHandler<GetListExamQuery, ExamListModel>
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public GetListExamQueryHandler(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        async Task<ExamListModel> IRequestHandler<GetListExamQuery, ExamListModel>.Handle(GetListExamQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Exam> exams = await _examRepository.GetListAsync(
                    include: e=> e.Include(e => e.Subject).Include(i => i.Courses),
                    index: request.PageRequest.Page,
                    size: request.PageRequest.PageSize   
                );

            ExamListModel examListModel = _mapper.Map<ExamListModel>(exams);
            return examListModel;
        }
    }
}
