using System.Collections.Generic;
using StudentInformationSystem.Entity;

namespace StudentInformationSystem.BusinessLayer.Repository
{
    public interface ICourseRepository
    {
        void Add(Course course);
        void Update(Course course);
        void Delete(int courseId);
        Course GetById(int courseId);
        IEnumerable<Course> GetAll();
    }
}
