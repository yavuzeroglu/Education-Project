using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Features.Questions.DTOs
{
    public class GetListQuestionDto
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public string ExamQuestion { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswer { get; set; }
        public string? TraineeAnswer { get; set; }
        public bool? IsCorrect { get; set; }

    }
}
