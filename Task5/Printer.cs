using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Printer
    {
        static Random r = new Random();
        public virtual void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
