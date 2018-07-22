using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter name and age");
            string n = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            PersonInfoAuto auto = new
                PersonInfoAuto();
            auto.Name = n;
            auto.age = a;
            Console.WriteLine(auto.Name + "\n" + auto.age);
            PersonInfoCLR clr = new PersonInfoCLR
            {
                Name = "king",
                Age = 58
            };
            Console.WriteLine(clr.Name + " " + clr.Age);

        }
    }
}
