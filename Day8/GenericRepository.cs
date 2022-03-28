using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        List<T> _list;
        public GenericRepository()
        {
            _list = new List<T>();
        }
        public void Add(T Item)
        {
            _list.Add(Item);
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> list = new List<T>();
            foreach (T Item in _list)
            {
                list.Append(Item);
            }
            return list;
        }

        public T GetById(int Id)
        {
            foreach(T Item in _list)
            {
                if (Item.Id == Id)
                    return Item;
            }
            return default;
        }

        public void Remove(T Item)
        {
            _list.Remove(Item);
        }

        public void Save()
        {
            //not clear what the requirement is
        }
    }
}
