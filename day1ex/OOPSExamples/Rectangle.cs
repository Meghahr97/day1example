using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    class Rectangle:Shapes
    {
        int len;
        int brd;

        public override void DisplayShapes()
        {
            base.DisplayShapes(); //this will call the parent class method
            Console.WriteLine("rectangle class");
        }
        public override void DisplayArea()
        {
            //throw new NotImplementedException();
            len = 200;
            brd = 50;
            area = len * brd;
            Console.WriteLine("area of rectangle" + area);

        }
    }
}
