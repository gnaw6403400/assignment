using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IRepository<T>
    {
        void Add(T Item);
        void Remove(T Item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int Id);

    }
}
