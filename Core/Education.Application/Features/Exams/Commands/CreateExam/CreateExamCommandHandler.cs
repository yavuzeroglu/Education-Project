using AutoMapper;
using Education.Application.Features.Exams.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Exams.Commands.CreateExam
{
    public class CreateExamCommandHandler : IRequestHandler<CreateExamCommand, CreateExamDto>
    {
        private readonly IMapper _mapper;
        private readonly IExamRepository _examRepository;

        public CreateExamCommandHandler(IMapper mapper, IExamRepository examRepository)
        {
            _mapper = mapper;
            _examRepository = examRepository;
        }

        public async Task<CreateExamDto> Handle(CreateExamCommand request, CancellationToken cancellationToken)
        {
            Exam exam = _mapper.Map<Exam>(request);
            exam = await _examRepository.AddAsync(exam);
            CreateExamDto createExamDto = _mapper.Map<CreateExamDto>(exam);
            return createExamDto;
        }
    }
}
