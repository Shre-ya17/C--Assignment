using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly List<Teacher> _teachers = new List<Teacher>();

        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Update(Teacher teacher)
        {
            var existing = GetById(teacher.Id);
            if (existing != null)
            {
                existing.Name = teacher.Name;
                existing.Email = teacher.Email;
            }
        }

        public void Delete(int teacherId)
        {
            var teacher = GetById(teacherId);
            if (teacher != null)
            {
                _teachers.Remove(teacher);
            }
        }

        public Teacher GetById(int teacherId)
        {
            return _teachers.FirstOrDefault(t => t.Id == teacherId);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _teachers;
        }
    }
}
