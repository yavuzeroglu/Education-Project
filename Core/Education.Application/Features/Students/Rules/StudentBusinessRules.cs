using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistance.Paging;
using Education.Application.Services.Repositories;
using Education.Domain.Entities;

namespace Education.Application.Features.Students.Rules
{
    public class StudentBusinessRules
    {
        private readonly IStudentRepository _studentRepository;

        public StudentBusinessRules(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task StudentEmailCanNotDuplicatedWhenInserted(string email)
        {
            IPaginate<Student> student = await _studentRepository.GetListAsync(s => s.Email == email);
            if (student.Items.Any()) throw new BusinessException($"{email} student exists");
        }

        public void StudentShouldExistWhenRequsted(Student student)
        {
            if (student is null) 
                throw new BusinessException("Requested student does not exist");
        }
        public async Task ShouldHaveValidId(int studentId)
        {
            var result = await _studentRepository.GetAsync(c => c.Id == studentId);
            if (result is null)
                throw new BusinessException("Student's Id is not found!");
        }
    }
}
