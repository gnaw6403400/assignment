using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyList<T> 
    {
        public List<T> list;

        public MyList()
        {
            list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                T element = list[index];
                list.RemoveAt(index);
                return element;
            }
            return default(T);    
        }


        public bool Contains(T element)
        {
            return list.Contains(element);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            if (index >= 0 && index < list.Count)
                list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index >= 0 && index < list.Count)
                list.RemoveAt(index);
        }

        public T Find(int index)
        {
            
            if (index >= 0 && index < list.Count)
                return list[index];
            return default(T);
        }
        
    }
}
