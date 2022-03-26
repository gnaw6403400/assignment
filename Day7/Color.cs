using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public byte Red { get { return red; } set { red = value; } }
        public byte Green { get { return green; } set { green = value; } }
        public byte Blue { get { return blue; } set { blue = value; } }
        public byte Alpha { get { return alpha; } set { alpha = value; } }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }


        public float GetGrey()
        {
            return ((float)red + (float)green + (float)blue ) / 3;
        }

    }
}
