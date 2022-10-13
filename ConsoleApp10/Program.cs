using System;

namespace ConsoleApp10

{
    abstract class Duck // 把Duck类改为抽象类怎么样？
    {
        public string Name { get; set; }
        public void quack()
        {
            Console.WriteLine("鸭子都会叫！");
        }
        public void swim()
        {
            Console.WriteLine("鸭子会游泳！");
        }
        public void fly()
        {
            Console.WriteLine("{0}鸭子会飞！", Name);
        }
        public void display()
        {
            Console.WriteLine("这是一只{0}", Name);
        }
    }
    class MailardDuck : Duck  //麻鸭类
    {
        public MailardDuck()
        {
            Name = "MailardDuck";
        }
    }
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            Name = "RedheadDuck";
        }

    }
    class RobberDuck : Duck
    {
        public RobberDuck()
        {
            Name = "RobberDuck";
        }
        public new void fly() // 覆盖原fly方法
        {
            Console.WriteLine("{0}鸭子不会飞！", Name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Duck duck1 = new MailardDuck();
            Duck duck2 = new RedheadDuck();
            RobberDuck duck3 = new RobberDuck();

            duck1.display();
            duck1.fly();
            duck2.display();
            duck2.fly();
            duck3.display();
            duck3.fly();
        }
    }
}