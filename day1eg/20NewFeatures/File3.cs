using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20NewFeatures
{
   partial class Employee
    {
        public void ShowData()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("name:" + name);
            Console.WriteLine("dept:" + dept);
            Console.WriteLine("sal:" + salary);


        }
    }
}
