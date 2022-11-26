using Core.Application.Requests;
using Education.Application.Features.Questions.Models;
using MediatR;

namespace Education.Application.Features.Questions.Queries.GetListQuestion
{
    public class GetListQuestionQuery : IRequest<QuestionListModel>
    {
        public PageRequest PageRequest { get; set; }
    }
}
