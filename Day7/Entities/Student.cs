using Assignment3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    public class Student : Person
    {
        public List<Course> courses { get; set; }
        public float GPA { get; set; }

        public Student()
        {
            courses = new List<Course>();
        }
    }

    public class StudentService : PersonService, IStudentService
    {
        public Student student;

        public StudentService()
        {
            student = new Student();
        }

        public float GetGPA()
        {
            float avg = 0;
            foreach (Course course in student.courses)
            {
                avg += course.studentList[student];
            }

            student.GPA = avg / student.courses.Count;

            return student.GPA;
        }

        public string GetGrade(Course course)
        {
            switch (course.studentList[student]){
                case 0:
                    return "F";
                case 1:
                    return "D";
                case 2:
                    return "C";
                case 3:
                    return "B";
                default:
                    return "A";
            }
        }
    }
}
