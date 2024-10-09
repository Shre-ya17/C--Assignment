using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(int studentId);
        Student GetById(int studentId);
        IEnumerable<Student> GetAll();
    }
}
