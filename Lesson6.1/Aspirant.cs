using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Aspirant:Student
    {
        public new double getScholarShip()
        {
            if (AverageMark == 5) return 25000;
            return 15000;
        }
    }
}
