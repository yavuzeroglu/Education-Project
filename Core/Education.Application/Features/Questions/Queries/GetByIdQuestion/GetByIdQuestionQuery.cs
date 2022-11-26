using Education.Application.Features.Questions.DTOs;
using MediatR;

namespace Education.Application.Features.Questions.Queries.GetByIdQuestion
{
    public class GetByIdQuestionQuery : IRequest<GetByIdQuestionDto>
    {
        public int Id { get; set; }
    }
}
