using Assignment3.Entities;
using Assignment3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    enum Departments { English, Engineering, Art }
    public class Department
    {
        public List<Course> courses;
        public Instructor? headOfDept { get; set; }
        public decimal budget;

        public Department()
        {
            headOfDept = null;
            courses = new List<Course>();
        }
    }


    public class DepartmentService : IDepartmentServices
    {
        public Department department;
        public DepartmentService()
        {
            department = new Department();
        }

        public void AddCourse(Course c)
        {
            department.courses.Add(c);
        }

        public void DeleteCourse(Course c)
        {
            if(department.courses.Contains(c))
                department.courses.Remove(c);
        }

        public void NominateHead(Instructor instructor)
        {
            if(department.headOfDept == null)
            {
                department.headOfDept = instructor;
                instructor.isHeadOfDept = true;
            }
            else
            {
                department.headOfDept.isHeadOfDept = false;
                department.headOfDept = instructor;
                instructor.isHeadOfDept = true;
            }
        }

        public void SetBudget(decimal budget)
        {
            department.budget = budget;
        }
    }


}
