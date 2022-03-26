using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Interfaces
{
    interface IPersonService
    {
        public int GetAge();
        public List<string> GetAddresses();
        public decimal GetSalary();
    }
}
