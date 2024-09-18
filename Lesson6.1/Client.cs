using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Client:Person
    {
        public string Bank { get; set; }
        public Client(string name,string bank) : base(name)
        {
            Bank = bank;
        }
        public override string? ToString()
        {
            return "Меня зовут:" + Name+" Я клиент банка:"+Bank;
        }
    }
}
