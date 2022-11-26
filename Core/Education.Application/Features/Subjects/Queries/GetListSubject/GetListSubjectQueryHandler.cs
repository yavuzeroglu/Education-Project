using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Subjects.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Subjects.Queries.GetListSubject
{
    public class GetListSubjectQueryHandler : IRequestHandler<GetListSubjectQuery, SubjectListModel>
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public GetListSubjectQueryHandler(ISubjectRepository subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<SubjectListModel> Handle(GetListSubjectQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Subject> subjects = await _subjectRepository.GetListAsync(
                include: c => c.Include(c => c.Lesson),
                size: request.PageRequest.PageSize,
                index: request.PageRequest.Page
                );
            SubjectListModel subjectListModel = _mapper.Map<SubjectListModel>(subjects);

            return subjectListModel;
        }
    }
}
