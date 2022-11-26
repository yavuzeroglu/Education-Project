namespace Education.Application.Features.Questions.DTOs
{
    public class GetByIdQuestionDto
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
