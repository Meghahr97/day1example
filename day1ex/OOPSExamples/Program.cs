using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo p1 = new PersonInfo();
            p1.Getdata();
            p1.showdata();
            PersonInfo p2 = new PersonInfo();
            p2.showdata();
            PersonInfo p3 = new PersonInfo("blake", 59, "blake@hotmail.com");
            p3.showdata();

            Shapes s = new Rectangle();
            s.DisplayArea();
            s.DisplayShapes();

            Bird b = new Bird();
            b.fly();
            kite k = new kite();
            k.fly();
            plane p = new plane();
            p.fly();
            p.PrintTicket();


        }
    }
}
