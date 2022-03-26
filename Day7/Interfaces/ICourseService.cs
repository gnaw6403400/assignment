using Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Interfaces
{
    interface ICourseService
    {
        public void AddStudents(Student student);
        public void RemoveStudents(Student student);
        public int GetStudentCount();
        public void SetStudentGrade(Student student, int grades);

    }
}
