using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class ChildClass:BaseClass
    {
        public int Second {  get; set; }

        public override int this[int index] => base[index];
    }
}
