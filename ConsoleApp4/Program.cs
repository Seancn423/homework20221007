using System;

namespace ConsoleApp4
{
    class Program
    {
        public class round
        {
            public double r { get; set; }
            public round() { }
            public round(double a)
            {
                this.r = a;
            }
            public double s()
            {
                return 3.14*r*r;
            }
            public double c()
            {
                return 2 * 3.14 * r;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入圆的半径：");
            double a = Convert.ToInt32(Console.ReadLine());
            round r = new round(a);
            Console.WriteLine("周长为：" + r.c());
            Console.WriteLine("面积为：" + r.s());
        }
    }
}
