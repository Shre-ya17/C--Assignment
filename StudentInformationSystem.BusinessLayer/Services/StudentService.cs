using System.Collections.Generic;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer.Repository;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.Update(student);
        }

        public void DeleteStudent(int studentId)
        {
            _studentRepository.Delete(studentId);
        }

        public Student GetStudentById(int studentId)
        {
            return _studentRepository.GetById(studentId);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
    }
}
