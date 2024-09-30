using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    delegate void MyDelegate();
    internal class MyClass
    {
        
        public static void Main()
        {
            MyDelegate mes;
            mes = Hello;
            mes();
            void Hello() => Console.WriteLine("Hello, me");
        }
    }
}
