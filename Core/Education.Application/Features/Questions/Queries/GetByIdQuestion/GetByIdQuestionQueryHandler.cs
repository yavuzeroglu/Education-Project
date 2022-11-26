using AutoMapper;
using Education.Application.Features.Questions.DTOs;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Questions.Queries.GetByIdQuestion
{
    public class GetByIdQuestionQueryHandler : IRequestHandler<GetByIdQuestionQuery, GetByIdQuestionDto>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public GetByIdQuestionQueryHandler(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdQuestionDto> Handle(GetByIdQuestionQuery request, CancellationToken cancellationToken)
        {
            Question? question = await _questionRepository.GetAsync(d => d.Id == request.Id);
            GetByIdQuestionDto getByIdQuestionDto = _mapper.Map<GetByIdQuestionDto>(question);

            return getByIdQuestionDto;



        }
    }
}
