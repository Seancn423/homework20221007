using System;

namespace ConsoleApp5
{
    class Program
    {
        public class Rect
        {
            public int width;
            public int height;

            public Rect()
            {
                this.width = 10;
                this.height = 10;
            }
            public Rect(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
            public int area()
            {
                return width * height;
            }
            public int intperimeter()
            {
                return (width + height) * 2;
            }
        }
        public class PlainRect : Rect 
        {
            public double startX;
            public double startY;

            public PlainRect()
            {
                this.width = 10;
                this.height = 10;
                this.startX = 0;
                this.startY = 0;
            }

            public PlainRect(int width, int height,double startX, double startY)
            {
                this.width = width;
                this.height = height;
                this.startX = startX;
                this.startY = startY;
            }
            public bool isInside(double x, double y)
            {
                if (x > startX && x < startX + height && y < startY && y > startY - width) return true;
                else return false;
            }
        }
        static void Main(string[] args)
        {
            PlainRect pl = new PlainRect(10, 20, 10, 10);
            Console.WriteLine("面积为" + pl.area());
            Console.WriteLine("周长为"+pl.intperimeter());
            Console.WriteLine("点是否在矩形内：" + pl.isInside(25.5,13));
        }
    }
}
