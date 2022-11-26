namespace Education.Application.Features.Exams.DTOs
{
    public class GetListExamDto
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public IReadOnlyCollection<string>? Course { get; set; }
    }
}
