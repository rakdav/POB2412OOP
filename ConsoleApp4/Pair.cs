using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Pair
    {
        public double First {  get; set; }
        public double Second { get; set; }
        public double Sum()=>First+Second;
        public double Max()=>(First>Second)?First:Second;
    }
}
