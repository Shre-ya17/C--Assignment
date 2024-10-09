using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Services
{
    public interface ICourseService
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(int courseId);
        Course GetCourseById(int courseId);
        IEnumerable<Course> GetAllCourses();
    }
}
