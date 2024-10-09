using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly List<Student> _students = new List<Student>();

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Update(Student student)
        {
            var existing = GetById(student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.DateOfBirth = student.DateOfBirth;
                existing.Email = student.Email;
            }
        }

        public void Delete(int studentId)
        {
            var student = GetById(studentId);
            if (student != null)
            {
                _students.Remove(student);
            }
        }

        public Student GetById(int studentId)
        {
            return _students.FirstOrDefault(s => s.Id == studentId);
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }
    }
}
