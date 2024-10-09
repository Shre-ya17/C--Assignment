using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Entity
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<Course> AssignedCourses { get; set; } = new List<Course>();

        public Teacher(string name)
        {
            Name = name;
        }
    }
}
