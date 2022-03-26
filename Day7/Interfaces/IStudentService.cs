﻿using Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Interfaces
{
    interface IStudentService : IPersonService
    {
        public string GetGrade(Course course);
        public float GetGPA();
    }
}
