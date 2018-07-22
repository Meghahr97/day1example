using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    class Bird : IFlying
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("flap flap flap");
        }
    }
    class kite : IFlying
    {
        public void fly()
        {
            //throw new NotImplementedException();
            Console.WriteLine("flies colorfully with tail and thread");
        }
    }
    class plane : IFlying, IPassengerInfo
    {
        public void fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Up Up in sky");
        }

        public void PrintTicket()
        {
            // throw new NotImplementedException();
            Console.WriteLine("passenger Name:Megha");
            Console.WriteLine("source:Bengaluru");
            Console.WriteLine("destination:new delhi");
            Console.WriteLine("pnr No:123");
            Console.WriteLine("doj:07/04/2018");
            Console.WriteLine("Seat No:EA");

        }
    }

}
