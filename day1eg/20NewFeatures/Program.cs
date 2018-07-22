using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ShowData();
            Employee emp1 = new Employee(11, "king", "CEO", 213132);
            emp1.ShowData();

            for (int i = 0; i < 10; i++)
                Counter.CountData();


            int num1 = 100;
            int num2 = 200;
            string str1 = "hello";
            string str2 = "world";
            Console.WriteLine("Before swap:" + num1 + " " + num2);
            SwapExample<int> intobj = new
                SwapExample<int>();
            intobj.Swap(ref num1, ref num2);
            Console.WriteLine("after swap:" + num1 + " " + num2);

            Console.WriteLine("before swap:" + str1 + " " + str2);
            SwapExample<string> stringobj = new
                SwapExample<string>();
            stringobj.Swap(ref str1, ref str2);
            Console.WriteLine("after swap:" + str1 + " " + str2);

            int? age = 32;
            double? pi = null;

            if (age.HasValue)
                Console.WriteLine(age.Value);
            else
                Console.WriteLine("Age:NULL");

            if (pi.HasValue)
                Console.WriteLine(pi.Value);
            else
                Console.WriteLine("PI:NULL");




        }
    }
}
