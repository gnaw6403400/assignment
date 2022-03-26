using Assignment3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Entities
{
    public class Instructor : Person
    {
        public int departmentID { get; set; }
        public bool isHeadOfDept { get; set; }
        public DateTime joinDate { get; set; }
        public decimal baseSalary { get; set; }

    }

    public class InstructorService : PersonService, IInstructorService
    {
        public Instructor instructor;

        public InstructorService()
        {
            instructor = new Instructor();
        }

        public decimal GetBonus()
        {
            return  (instructor.joinDate.Day - DateTime.Now.Day) / 365 * 5000;
        }

        public override decimal GetSalary()
        {
            
            return instructor.baseSalary + GetBonus();
        }
    }
}
