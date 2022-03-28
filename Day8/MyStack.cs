using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyStack<T>
    {
        Stack<T> stack;

        public MyStack()
        {
            stack = new Stack<T>();
        }

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public void Push(T item)
        {
            stack.Push(item);
        }


    }
}
