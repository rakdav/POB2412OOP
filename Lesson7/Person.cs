using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Person
    {
        public string? FIO { get; set; }
        public DateOnly? DateBirthday { get; set; }
        public string? Phone { get; set; }
        public Person(string? fIO, DateOnly? dateBirthday, 
                        string? phone)
        {
            FIO = fIO;
            DateBirthday = dateBirthday;
            Phone = phone;
        }
        public virtual void TakeBook(int n){}
        public virtual void TakeBook(params string[] books){}
        public virtual void TakeBook(params Book[] books){}
    }
}
