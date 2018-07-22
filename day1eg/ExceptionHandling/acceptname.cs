using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class acceptname
    {
        public void inputName()
        {
            Console.WriteLine("enter name in block letters");
            string name = Console.ReadLine();
            char[] ch = name.ToCharArray();
            foreach(char c in ch)
            {
                if(!char.IsUpper(c))
                {
                    throw new UpperNameException();

                }
            }
            Console.WriteLine("name entered is valid");
            Console.WriteLine("name:" + name);

        }
    }
}
