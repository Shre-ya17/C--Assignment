using System.Collections.Generic;
using System.Linq;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly List<Course> _courses = new List<Course>();

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Update(Course course)
        {
            var existing = GetById(course.Id);
            if (existing != null)
            {
                existing.CourseCode = course.CourseCode;
                existing.Title = course.Title;
            }
        }

        public void Delete(int courseId)
        {
            var course = GetById(courseId);
            if (course != null)
            {
                _courses.Remove(course);
            }
        }

        public Course GetById(int courseId)
        {
            return _courses.FirstOrDefault(c => c.Id == courseId);
        }

        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }
    }
}
