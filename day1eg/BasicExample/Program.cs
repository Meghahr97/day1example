using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            bool cab;
            DateTime doj;
            //parse function is used to convert string into different data type 
            Console.WriteLine("enter id");
            // id = int.Parse(Console.ReadLine());
            bool res = int.TryParse(Console.ReadLine(), out id);
            if(res==false)
            {
                Console.WriteLine("id has to be integer value");
                return;
            }
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("enter cab(true/false)");
            cab = bool.Parse(Console.ReadLine());
            Console.WriteLine("enter dob");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID:" + id);
            Console.WriteLine("name:" + name);
            Console.WriteLine("gender:" + gender);
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("cab:" + cab);
            Console.WriteLine("date:" + doj);


        }
    }
}
