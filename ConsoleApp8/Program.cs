using System;

namespace ConsoleApp8
{
    class Program
    {
        public interface interfaceA
        {
            public void printCapitalLetter();
        }
        public interface interfaceB
        {
            public void printLowercaseLetter();
        }
        public class print : interfaceA, interfaceB
        {
            public void printCapitalLetter()
            {
                Console.WriteLine("大写字母");
                for (int i = 1; i <= 26; i++)
                {
                    Console.WriteLine((char)(i + 64));
                }
            }
            public void printLowercaseLetter()
            {
                Console.WriteLine("小写字母");
                for (int i = 1; i <= 26; i++)
                {
                    Console.WriteLine((char)(i + 96));
                }
            }
         }
        static void Main(string[] args)
        {
            print a = new print();
            print b = new print();
            a.printCapitalLetter();
            b.printLowercaseLetter();
        }
    }
}
