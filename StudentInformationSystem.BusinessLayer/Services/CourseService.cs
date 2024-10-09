using System.Collections.Generic;
using StudentInformationSystem.Entity;
using StudentInformationSystem.BusinessLayer.Repository;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Add(course);
        }

        public void UpdateCourse(Course course)
        {
            _courseRepository.Update(course);
        }

        public void DeleteCourse(int courseId)
        {
            _courseRepository.Delete(courseId);
        }

        public Course GetCourseById(int courseId)
        {
            return _courseRepository.GetById(courseId);
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }
    }
}
