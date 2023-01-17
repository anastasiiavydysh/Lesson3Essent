using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane:Vehicle
    {
        public double Height { get; set; }
        public int PassengersCount { get; set; }

        public Plane(int x, int y, decimal price, double speed, int createYear, double height, int passengersCount) : base(x, y, price, speed, createYear)
        {
            Height = height;
            PassengersCount = passengersCount;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Passengers Count = " + PassengersCount + ", Height = " + Height);
        }
    }
}
