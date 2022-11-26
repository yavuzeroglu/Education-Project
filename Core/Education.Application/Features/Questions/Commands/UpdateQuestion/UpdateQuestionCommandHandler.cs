using AutoMapper;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionCommandHandler : IRequestHandler<UpdateQuestionCommand, UpdateQuestionDto>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public UpdateQuestionCommandHandler(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<UpdateQuestionDto> Handle(UpdateQuestionCommand request, CancellationToken cancellationToken)
        {
            Question question = await _questionRepository.GetAsync(d => d.Id == request.Id);

            question = _mapper.Map(request, question);
            question = await _questionRepository.UpdateAsync(question);

            UpdateQuestionDto updateQuestionDto = _mapper.Map<UpdateQuestionDto>(question);
            return updateQuestionDto;
        }
    }
}
