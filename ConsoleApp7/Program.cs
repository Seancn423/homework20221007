using System;

namespace ConsoleApp7
{
    class Program
    {
        public abstract class Animal
        {
            public string name;
            protected Animal() { }
            protected Animal(string name)
            {
                this.name = name;
            }
            public abstract void enjoy();
        }
        public class Cat : Animal 
        {
            public string eyesColor;

            public Cat(){}
            public Cat(string name,string eyesColor)
            {
                this.name = name;
                this.eyesColor = eyesColor;
            }
            public override void enjoy()
            {
                Console.WriteLine("猫高兴时会笑");
            }
        }
        public class Dog : Animal
        {
            public string furColor;

            public Dog() { }
            public Dog(string name, string furColor)
            {
                this.name = name;
                this.furColor = furColor;
            }
            public override void enjoy()
            {
                Console.WriteLine("狗高兴时会叫");
            }
        }
        public class Lady
        {
            public string name;
            public Animal pet;

            public Lady(){}
            public Lady(string name, Animal pet)
            {
                this.name = name;
                this.pet = pet;
            }
            public void myPetEnjoy()
            {
                if (pet.GetType()== typeof(Cat))
                {
                    pet.enjoy();
                }
                else if (pet.GetType() == typeof(Dog))
                {
                    pet.enjoy();
                }
            }
        }
        static void Main(string[] args)
        {
            Animal dog = new Dog("bob","black");
            Animal cat = new Cat("alice", "white");
            Lady lady1 = new Lady("张女士",cat);
            Lady lady2 = new Lady("王女士", dog);
            lady1.myPetEnjoy();
            lady2.myPetEnjoy();
        }
    }
}
