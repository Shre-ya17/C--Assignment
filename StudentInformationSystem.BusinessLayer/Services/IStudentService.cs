using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);
        Student GetStudentById(int studentId);
        IEnumerable<Student> GetAllStudents();
    }
}
