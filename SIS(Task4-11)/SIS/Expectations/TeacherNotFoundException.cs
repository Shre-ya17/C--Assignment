using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Expectations
{
    public class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException(string message) : base(message) { }
    }
}
