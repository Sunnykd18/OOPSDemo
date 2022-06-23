using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize on same line
            Rectangle rectangle = new Rectangle();

            // declare
            Rectangle rectangle1;
            //initialize 
            rectangle1 = new Rectangle();

            rectangle.Length = int.Parse(Console.ReadLine());
           // rectangle.Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of rectangle is " + rectangle.Area());
            Console.ReadLine();

           
        }
    }
}
