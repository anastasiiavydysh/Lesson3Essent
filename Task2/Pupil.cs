using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Pupil
    {
        public virtual void Study() 
        {
            Console.WriteLine("Class Pupil, method Study");
        }
        public virtual void Read() 
        {
            Console.WriteLine("Class Pupil, method Read");
        }
        public virtual void Write() 
        {
            Console.WriteLine("Class Pupil, method Write");
        }
        public virtual void Relax() 
        {
            Console.WriteLine("Class Pupil, method Relax");
        }
    }
}
