using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Counter
    {
        public int Low {  get; set; }
        public int High { get; set; }
        private int count;
        public int Count { get { return count; }
                           set { 
                                    if (value >= Low && value <= High)
                                        count = value;
                                    else count = Low;
                                } 
                         }
        public void Inc() 
        { 
            if (Count != High) Count++;
                            else Count = High;
        }
        public void Decrement() { Count--; }
        public void Valide()
        {
            if(Low>High)
            {
                int temp=Low;
                Low=High;
                High=temp;
            }
        }
    }
}
