using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Interfaces;

namespace Assignment3
{
    //having multiple class in a file to reduce number of files
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<string> Addresses { get; set; }

        public Person()
        {
            Addresses = new List<string>();
        }
    }

    public class PersonService : IPersonService
    {
        public Person person;
        public PersonService()
        {
            person = new Person();
        }
        public List<string> GetAddresses()
        {
            return person.Addresses;
        }

        public int GetAge()
        {
            return (DateTime.Now - person.Birthday).Days / 365;
        }

        public virtual decimal GetSalary()
        {
            return 0;
        }
    }


    


    
}
