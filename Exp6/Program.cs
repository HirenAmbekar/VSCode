using System;

namespace Rectangle_testor
{
    class Shape
    {
        public int l;
        public int b;
        public void setSide1(int s1)
        {
            this.l = s1;
        }
        public void setSide2(int s2)
        {
            this.b = s2;
        }
    }

    class Rectangle : Shape
    {
        public int getA()
        {
            return (l * b);
        }
    }
    class Square : Shape
    {
        public int getA()
        {
            return (l * l);
        }
    }
    class RectangleTester1
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            Square Sq = new Square();
            Rect.setSide1(11);
            Rect.setSide2(8);
            Sq.setSide1(10);
            Console.WriteLine("Total area of Reactangle: "+ Rect.getA());
            Console.WriteLine("Total area of Square: " + Sq.getA());

            Console.ReadLine();
        }

    }

}