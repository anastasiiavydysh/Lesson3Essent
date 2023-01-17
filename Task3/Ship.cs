using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Ship:Vehicle
    {
        public int PassengersCount { get; set; }
        public string PortPrypysky { get; set; }
        public Ship(int x, int y, decimal price, double speed, int createYear, int passangersCount, string portPrypysky) 
            :base(x, y, price, speed, createYear)
        {
            PassengersCount = passangersCount;
            PortPrypysky = portPrypysky;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Passengers Count = " + PassengersCount + ", PortPrypysky = " + PortPrypysky);
        }
    }
}
