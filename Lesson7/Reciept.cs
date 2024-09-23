using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Reciept
    {
        private long number;
        public long Number 
        { 
            get { return number; } 
            set { if(value>0) number = value; } 
        }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { if(value>0) amount = value; }
        }
    }
}
