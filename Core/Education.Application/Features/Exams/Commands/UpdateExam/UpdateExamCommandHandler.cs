using AutoMapper;
using Education.Application.Features.Exams.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Exams.Commands.UpdateExam
{
    public class UpdateExamCommandHandler : IRequestHandler<UpdateExamCommand, UpdateExamDto>
    {
        private readonly IExamRepository _examRepository;
        private readonly IMapper _mapper;

        public UpdateExamCommandHandler(IExamRepository examRepository, IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }

        public async Task<UpdateExamDto> Handle(UpdateExamCommand request, CancellationToken cancellationToken)
        {
            Exam exam = await _examRepository.GetAsync(e => e.Id == request.Id);

            exam = _mapper.Map(request, exam);
            exam = await _examRepository.UpdateAsync(exam);

            UpdateExamDto updateExamDto = _mapper.Map<UpdateExamDto>(exam);
            return updateExamDto;
        }
    }
}
