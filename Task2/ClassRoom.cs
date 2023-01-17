using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ClassRoom
    {
        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4)
                throw new Exception("Class must have more than 1 pupil and less than 5");
            foreach (var pupil in pupils)
            {
                Console.WriteLine("Study: ");
                pupil.Study();
                Console.WriteLine(" Write: ");
                pupil.Write();
                Console.WriteLine(" Read: ");
                pupil.Read();
                Console.WriteLine(" Relax: ");
                pupil.Relax();
                Console.WriteLine("------------------------");
            }
        }
    }
}
