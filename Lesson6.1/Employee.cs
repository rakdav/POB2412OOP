using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Employee:Person
    {
        public string Company { get; set; } = "";
        public Employee(string name,string company) :
            base(name)
        {
            Company = company;
        }
        public Employee()
        {

        }
        public new void Print()
        {
            Console.WriteLine("Меня зовут:" + Name+" Я работаю в:"+Company);
        }
    }
}
