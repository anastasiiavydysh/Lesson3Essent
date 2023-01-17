using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BadPupil:Pupil
    {
        public override void Study() 
        {
            Console.WriteLine("Class BadPupil, method Study");
        }
        public override void Read() 
        {
            Console.WriteLine("Class BadPupil, method Read");
        }
        public override void Write() 
        {
            Console.WriteLine("Class BadPupil, method Write");
        }
        public override void Relax() 
        {
            Console.WriteLine("Class BadPupil, method Relax");
        }
    }
}
