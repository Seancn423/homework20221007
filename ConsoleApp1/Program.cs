using System;

namespace ConsoleApp1
{
    class Program
    {
        public class rectangle
        {
            public double l { get; set; }
            public double w { get; set; }
            public rectangle() { }
            public rectangle(double a, double b)
            {
                this.l = a;
                this.w = b;
            }
            public double s()
            { 
                return l*w;
            }
            public double c() 
            {
                return (l + w) * 2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入长方形的长和宽：");
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            rectangle rec = new rectangle(a,b);
            Console.WriteLine("周长为：" + rec.c());
            Console.WriteLine("面积为：" + rec.s());
        }
    }
}
