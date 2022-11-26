using AutoMapper;
using Core.Persistance.Paging;
using Education.Application.Features.Questions.Models;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;
using MediatR;

namespace Education.Application.Features.Questions.Queries.GetListQuestion
{
    public class GetListQuestionQueryHandler : IRequestHandler<GetListQuestionQuery, QuestionListModel>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public GetListQuestionQueryHandler(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task<QuestionListModel> Handle(GetListQuestionQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Question> questions = await _questionRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

            

            QuestionListModel questionListModel = _mapper.Map<QuestionListModel>(questions);
            return questionListModel;
        }
    }
}
