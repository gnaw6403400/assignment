using Assignment3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Interfaces
{
    interface IDepartmentServices
    {
        public void NominateHead(Instructor instructor);
        public void SetBudget(decimal budget);
        public void AddCourse(Course c);
        public void DeleteCourse(Course c);

    }
}
