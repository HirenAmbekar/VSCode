using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void SampleDelegate(int a, int b);
    class MathOperation
    {
        public void Area_Of_Triangle(int a,int b)
        {
            int c = (a + b) / 2;
            Console.WriteLine("Area of Triangle : {0}",c);
        }

        public void Area_Of_Rectangle(int a, int b)
        {
            Console.WriteLine("Area of Rectangle : {0}", a*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation m = new MathOperation();

            // Single cast delegate 

            Console.WriteLine("**Single Cast Delegate**");
            Console.Write("\n");

            SampleDelegate dgt = m.Area_Of_Triangle;
            dgt(4, 8);

            dgt = m.Area_Of_Rectangle;
            dgt(8, 8);
            Console.Write("\n");
            // Multicast delegates

            Console.WriteLine("**MultiCast Delegate**");
            Console.Write("\n");

            // Add methods using + operator 

            Console.WriteLine("Adding Method reference using + operator");

            SampleDelegate dgt1 = m.Area_Of_Triangle;
            dgt1+= m.Area_Of_Rectangle;

            dgt1(6, 6);

            Console.Write("\n");
            // Remove method  using - operator

            Console.WriteLine("Removing Method reference using - operator");

            dgt1 -= m.Area_Of_Rectangle;
            dgt1(4, 4);
            Console.Write("\n");
            Console.Write("Press any key to exit..");


            Console.ReadLine();


        }
    }
}
