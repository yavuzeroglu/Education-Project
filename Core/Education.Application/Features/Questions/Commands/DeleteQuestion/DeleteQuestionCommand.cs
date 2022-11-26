using Education.Application.Features.Questions.DTOs;
using MediatR;

namespace Education.Application.Features.Questions.Commands.DeleteQuestion
{
    public class DeleteQuestionCommand : IRequest<DeleteQuestionDto>
    {
        public int Id { get; set; }

    }
}
