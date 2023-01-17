using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Car:Vehicle
    {
        public Car(int x, int y, decimal price, double speed, int createYear) :base(x, y, price, speed, createYear)
        { 
        }

        public override void Print()
        {
            base.Print();
        }
    }
}
