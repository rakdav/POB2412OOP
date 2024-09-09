using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class TwoPair
    {
        private int one;
        private int two;
        public TwoPair()
        {
            this.one = 1;
            this.two = 1;
        }
        //public TwoPair(int one, int two)
        //{
        //    this.one = one;
        //    this.two = two;
        //}
        public TwoPair(TwoPair tp)
        {
            this.one = tp.one;
            this.two = tp.two;
        }
        public TwoPair(int a)
        {
            this.one = a;
            this.two = 1;
        }
        public TwoPair(int one, int two):this(one)
        {
            this.two = two;
        }
        public void Print()
        {
            Console.WriteLine("a="+one+" b="+two);
        }
    }
}
