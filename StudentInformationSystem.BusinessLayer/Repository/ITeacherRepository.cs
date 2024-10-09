using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public interface ITeacherRepository
    {
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int teacherId);
        Teacher GetById(int teacherId);
        IEnumerable<Teacher> GetAll();
    }
}
