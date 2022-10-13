using System;

namespace ConsoleApp9
{
    class Program
    {
        public interface A
        {
            public double area();
        }
        public interface B
        {
            public abstract void setColor(String c);
        }
        public interface C : A, B
        {
            public void volume();
        }
        public class Cylinder : C
        {
            public double radius;
            public double height;
            public string color;

            public Cylinder() { }
            public Cylinder(double radius, double height)
            {
                this.radius = radius;
                this.height = height;
            }
            public Cylinder(double radius, double height, string color)
            {
                this.radius = radius;
                this.height = height;
                this.color = color;
            }

            public double area()
            {
                return 3.14 * 2 * radius * radius + 2 * radius * 3.14 * height;
            }

            public void setColor(string c)
            {
                this.color = c;
            }

            public void volume()
            {
                Console.WriteLine("体积是" + 3.14 * radius * radius * height);
            }
        }
        static void Main(string[] args)
        {
            Cylinder cy = new Cylinder(2, 4);
            cy.setColor("red");
            Console.WriteLine("表面积是" + cy.area());
            cy.volume();
            Console.WriteLine("颜色是" + cy.color);
        }
    }
}
