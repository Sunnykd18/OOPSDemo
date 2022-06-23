using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Rectangle
    {
        // fields - attribute
        // methods - behaviour

        private int length, width;

        public int Length
        {
            get { return length; }
            set { length = value; width = 7; } // parameter
        }
        public int Width
        { 
            get { return width; }
            set { width = value; } // parameter
        }
     
        public int Area()
        {
            return length * width;
        }
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }
    }
}
