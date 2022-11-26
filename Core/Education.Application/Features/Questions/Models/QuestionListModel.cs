using Education.Application.Features.Questions.DTOs;

namespace Education.Application.Features.Questions.Models
{
    public class QuestionListModel
    {
        public IList<GetListQuestionDto> Items { get; set; }
    }
}
