using Core.Persistance.Repositories;

namespace Education.Domain.Entities
{
    public class Student : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; } = false;

        public virtual ICollection<Course> Courses { get; set; }

        public Student()
        { }

        public Student(int id, string name, string surname, string email, string password, string phone, bool isActive)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            Phone = phone;
            IsActive = isActive;
        }

    }
}
