using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    class PersonInfo
    {
        string name;
        int age;
        string email;

        public void Getdata()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter email");
            email = Console.ReadLine();

        }
        public void showdata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("age:" + age);
            Console.WriteLine("email:" + email);

        }
        public PersonInfo()
        {
            // CLR null for string -int takes 0
            name = "default";
            age = 99;
            email = "default@default.com";
        }
        public PersonInfo(string name,int age,string em)
        {
            //parametr variables are local variables
            //data members are called as class member
            this.name = name;
            this.age = age;
            email = em;
        }
        ~PersonInfo()
        {
            GC.Collect();
            Console.WriteLine("object Destroyed");

        }
    }
}
