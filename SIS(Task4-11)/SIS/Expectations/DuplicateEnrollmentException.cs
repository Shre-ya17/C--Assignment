﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Expectations
{
    public class DuplicateEnrollmentException : Exception
    {
        public DuplicateEnrollmentException(string message) : base(message) { }
    }
}
