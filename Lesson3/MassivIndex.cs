using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class MassivIndex
    {
        public List<int> list { get; set; }=new();

        public MassivIndex()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(100); i++)
                list.Add(random.Next(10, 100));
        }
        public void Print()
        {
            foreach (int i in list) Console.Write(i+" ");
            Console.WriteLine();
        }
        public int this[int i]
        {
            get => list[i];
            set => list[i] = value;
        }
    }
}
