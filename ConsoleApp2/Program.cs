using System;

namespace ConsoleApp2
{
    class Program
    {
        public class employee
        {
            private int id;
            private string name { get; set; }
            private int departmentId { get; set; }

            public void setId(int id) 
            {
                this.id = id;
            }
            public int getId() 
            {
                return this.id;
            }
            public void setName(String  name)
            {
                this.name = name;
            }
            public String getName()
            {
                return this.name;
            }
            public void setDepartmentId(int departmentId)
            {
                this.departmentId = departmentId;
            }
            public int getDepartmentId()
            {
                return this.departmentId;
            }
            public employee(){}
            public employee(int id, string name,  int departmentId)
            {
                this.id = id;
                this.name = name;
                this.departmentId = departmentId;
            }
            public void show() 
            {
                Console.WriteLine("员工编号为" + getId());
                Console.WriteLine("员工姓名为" + getName());
                Console.WriteLine("员工部门编号为" + getDepartmentId());
            }
        }
        static void Main(string[] args)
        {
            employee em = new employee(1,"张三",12);
            em.show();
            em.setId(2);
            em.setName("李四");
            em.setDepartmentId(14);
            Console.WriteLine("员工编号为" + em.getId());
            Console.WriteLine("员工姓名为" + em.getName());
            Console.WriteLine("员工部门编号为" + em.getDepartmentId());

        }
    }
}
