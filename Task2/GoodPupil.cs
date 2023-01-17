using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GoodPupil:Pupil
    {
        public override void Study() 
        {
            Console.WriteLine("Class GoodPupil, method Study");
        }
        public override void Read() 
        {
            Console.WriteLine("Class GoodPupil, method Read");
        }
        public override void Write() {
            Console.WriteLine("Class GoodPupil, method Write");
        }
        public override void Relax() 
        {
            Console.WriteLine("Class GoodPupil, method Relax");
        }
    }
}
