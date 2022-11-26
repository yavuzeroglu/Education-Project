using AutoMapper;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommandHandler : IRequestHandler<CreateQuestionCommand, CreateQuestionDto>
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;

        public CreateQuestionCommandHandler(IMapper mapper, IQuestionRepository questionRepository)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
        }

        public async Task<CreateQuestionDto> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
        {
            Question question = _mapper.Map<Question>(request);
            question = await _questionRepository.AddAsync(question);

            CreateQuestionDto createQuestionDto = _mapper.Map<CreateQuestionDto>(question);
            return createQuestionDto;
        }
    }
}
