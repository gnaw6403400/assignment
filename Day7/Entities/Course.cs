using Assignment3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    enum Grades {F,D,C,B,A}
    public class Course
    {
        public Dictionary<Student,int> studentList;

        public Course()
        {
            studentList = new Dictionary<Student,int>();
        }
    }

    public class CourseService : ICourseService
    {
        public Course course;
        public CourseService()
        {
            course = new Course();
        }

        public void AddStudents(Student student)
        {
            course.studentList.Add(student, (int)Grades.A);
            student.courses.Add(course);
        }

        public void RemoveStudents(Student student)
        {
            if (course.studentList.ContainsKey(student))
            {
                course.studentList.Remove(student);
                student.courses.Remove(course);
            }
        }

        public int GetStudentCount()
        {
            return course.studentList.Count;
        }

        public void SetStudentGrade(Student student, int grades)
        {
            if (course.studentList.ContainsKey(student))
            {
                course.studentList[student] = grades;
            }

        }
    }
}
