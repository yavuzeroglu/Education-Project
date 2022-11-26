using AutoMapper;
using Education.Application.Features.Exams.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Education.Application.Features.Exams.Queries.GetByIdExam
{
    public class GetByIdExamQueryHandler : IRequestHandler<GetByIdExamQuery, GetByIdExamDto>
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public GetByIdExamQueryHandler(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdExamDto> Handle(GetByIdExamQuery request, CancellationToken cancellationToken)
        {
            Exam? exam = await _examRepository.GetAsync(e => e.Id == request.Id, 
                include: i => i.Include(e => e.Subject).Include(i => i.Courses));

            exam = _mapper.Map<Exam>(exam);
            GetByIdExamDto getByIdExamDto = _mapper.Map<GetByIdExamDto>(exam);

            return getByIdExamDto;
        }
    }
}
