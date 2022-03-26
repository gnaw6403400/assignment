using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Ball
    {
        private Color color;
        private int size;
        private int thrownCount;

        public Color Color { get { return color; } set { color = value; } }

        public Ball(Color c)
        {
            color = c;
            size = 1;
            thrownCount = 0;
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Thorw()
        {
            if (size != 0)
                thrownCount++;
        }

        public int GetCount()
        {
            return thrownCount;
        }
    }


    public class BallDriver
    {

        public void Run()
        {
            Color c = new Color(50, 60, 70, 100);
            Console.WriteLine(c.GetGrey());

            Ball b1 = new Ball(c);
            Ball b2 = new Ball(c);
            //throws both 10 times
            for (int i = 0; i < 10; i++)
            {
                b1.Thorw();
                b2.Thorw();
            }
            //pop b2
            b2.Pop();
            //throws both 10 more times, b2 will not count
            for (int i = 0; i < 10; i++)
            {
                b1.Thorw();
                b2.Thorw();
            }
            Console.WriteLine(b1.GetCount());
            Console.WriteLine(b2.GetCount());
            Console.WriteLine(b1.Color.Red);
            Console.WriteLine(b2.Color.Blue);
        }
    }
}
