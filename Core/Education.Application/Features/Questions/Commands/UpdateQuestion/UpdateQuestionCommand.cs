using Education.Application.Features.Questions.DTOs;
using MediatR;
using System.Reflection.Metadata.Ecma335;

namespace Education.Application.Features.Questions.Commands.UpdateQuestion
{
    public class UpdateQuestionCommand : IRequest<UpdateQuestionDto>
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string ExamQuestion { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswers { get; set; }
        public string? TraineeAnswer { get; set; }
        public bool? IsCorrect { get; set; }
    }
}
