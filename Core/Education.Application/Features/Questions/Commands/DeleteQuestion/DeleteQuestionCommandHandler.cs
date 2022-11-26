using AutoMapper;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;
using Microsoft.IdentityModel.Tokens;

namespace Education.Application.Features.Questions.Commands.DeleteQuestion
{
    public class DeleteQuestionCommandHandler : IRequestHandler<DeleteQuestionCommand, DeleteQuestionDto>
    {
        private readonly IMapper _mapper;
        private readonly IQuestionRepository _questionRepository;

        public DeleteQuestionCommandHandler(IMapper mapper, IQuestionRepository questionRepository)
        {
            _mapper = mapper;
            _questionRepository = questionRepository;
        }

        public async Task<DeleteQuestionDto> Handle(DeleteQuestionCommand request, CancellationToken cancellationToken)
        {
            Question? question = await _questionRepository.GetAsync(d => d.Id == request.Id);
            question = await _questionRepository.DeleteAsync(question);

            DeleteQuestionDto deleteQuestionDto = _mapper.Map<DeleteQuestionDto>(question);
            return deleteQuestionDto;




        }
    }
}
