using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Question : Entity
    {
        public int ExamId { get; set; }
        public string ExamQuestion { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswers { get; set; }
        public string? TraineeAnswer { get; set; } = null;
        public bool? IsCorrect { get; set; } = null;
        public bool IsActive { get; set; } = false;

        public virtual Exam? Exam { get; set; }

        public Question()
        { }

        public Question(int id, int examId, string examQuestion, string correctAnswer, string wrongAnswers, string? traineeAnswer, bool isCorrect, bool isActive)
        {
            Id = id;
            ExamId = examId;
            ExamQuestion = examQuestion;
            CorrectAnswer = correctAnswer;
            WrongAnswers = wrongAnswers;
            TraineeAnswer = traineeAnswer;
            IsCorrect = isCorrect;
            IsActive = isActive;
        }
    }
}
