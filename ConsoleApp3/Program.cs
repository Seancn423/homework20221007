using System;

namespace ConsoleApp3
{
    class Program
    {
        static class MyMath
        {
            public static void plus(int x, int y)
            {
                int temp = x + y;
                Console.WriteLine(x + "+" + y + "=" + temp);
            }
            public static void subtract(int x, int y)
            {
                int temp = x - y;
                Console.WriteLine(x + "-" + y + "=" + temp);
            }
            public static void multiplicative(int x, int y)
            {
                int temp = x * y;
                Console.WriteLine(x + "*" + y + "=" + temp);
            }
            public static void divide(int x, int y)
            {
                int temp = x / y;
                Console.WriteLine(x + "/" + y + "=" + temp);
            }
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            MyMath.plus(a,b);
            MyMath.subtract(a, b);
            MyMath.multiplicative(a, b);
            MyMath.divide(a, b);
        }
    }
}
