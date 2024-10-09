using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public interface ITeacherService
    {
        void AddTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacherId);
        Teacher GetTeacherById(int teacherId);
        IEnumerable<Teacher> GetAllTeachers();
    }
}
