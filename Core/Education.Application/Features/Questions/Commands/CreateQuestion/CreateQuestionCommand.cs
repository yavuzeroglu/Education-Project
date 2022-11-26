using Education.Application.Features.Questions.DTOs;
using MediatR;

namespace Education.Application.Features.Questions.Commands.CreateQuestion
{
    public class CreateQuestionCommand : IRequest<CreateQuestionDto>
    {
        public int ExamId { get; set; }
        public string ExamQuestion { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswers { get; set; }
        public string? TraineeAnswer { get; set; }
        public bool? IsCorrect { get; set; }
    }
}
