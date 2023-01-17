using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Class ExcelentPupil, method Study");
        }
        public override void Read() 
        {
            Console.WriteLine("Class ExcelentPupil, method Read");
        }
        public override void Write() 
        {
            Console.WriteLine("Class ExcelentPupil, method Write");
        }
        public override void Relax() 
        {
            Console.WriteLine("Class ExcelentPupil, method Relax");
        }
    }
}
