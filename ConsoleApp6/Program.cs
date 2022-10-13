using System;

namespace ConsoleApp6
{
    class Program
    {
        public class animal
        {
            public virtual void voice()
            {
                Console.WriteLine("动物发出声音");
            }
        }
        public class Cat : animal
        {
            public Cat(){}
            public override void voice()
            {
                Console.WriteLine("猫叫的声音是喵");
            }
        }
        public class Pig : animal
        {
            public Pig(){ }
            public override void voice()
            {
                Console.WriteLine("猪叫的声音是嘎");
            }
        }
        public class Dog : animal
        {
            public Dog(){}
            public override void voice()
            {
                Console.WriteLine("狗叫的声音是汪");
            }
        }
        public class store
        {
            public static animal getInstanc(string a)
            {
                if (a == "Cat")
                {
                    animal cat = new Cat();
                    return cat;
                }
                else if (a == "Pig")
                {
                    animal pig = new Pig();
                    return pig;
                }
                else if (a == "Dog")
                {
                    animal dog = new Dog();
                    return dog;
                }
                else
                {
                    animal an = new animal();
                    return an;
                }
            }
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                store.getInstanc(str).voice();
            }
        }
    }
}
