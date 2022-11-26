using Education.Application.Services.Repositories;

namespace Education.Application.Features.Subjects.Rules
{
    public class SubjectBusinessRules
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectBusinessRules(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
    }
}
