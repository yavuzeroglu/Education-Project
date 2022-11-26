using AutoMapper;
using Education.Application.Features.Exams.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Exams.Commands.DeleteExam
{
    public class DeleteExamCommandHandler : IRequestHandler<DeleteExamCommand, DeleteExamDto>
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public DeleteExamCommandHandler(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<DeleteExamDto> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
        {
            Exam? exam = await _examRepository.GetAsync(e => e.Id == request.Id);
            exam = await _examRepository.DeleteAsync(exam);

            DeleteExamDto deleteExamDto = _mapper.Map<DeleteExamDto>(exam);
            return deleteExamDto;
        }
    }
}
