using System.Collections.Generic;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer.Repository;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Add(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }

        public void DeleteTeacher(int teacherId)
        {
            _teacherRepository.Delete(teacherId);
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _teacherRepository.GetById(teacherId);
        }

        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAll();
        }
    }
}
