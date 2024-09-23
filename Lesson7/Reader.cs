using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Reader:Person
    { 
        private ulong number;
        public ulong Number
        {
            get { return number; }
            set { if(value>0) number = value; }
        }
        public string? Faculty {  get; set; }
        public Reader(string? fIO, DateOnly? dateBirthday,
                        string? phone,ulong n, string? fac) : 
                    base(fIO, dateBirthday, phone)
        {
            Number= n;
            Faculty= fac;
        }
        public override void TakeBook(int n)
        {
            Console.WriteLine($"{FIO} взял {n} книг");
        }
        public override void TakeBook(params string[] books)
        {
            Console.Write($"{FIO} взял книги:");
            foreach( var book in books ) 
            { 
                Console.Write(book+",");
            }
            Console.WriteLine();
        }
        public override void TakeBook(params Book[] books)
        {
            Console.Write($"{FIO} взял книги:");
            foreach (var book in books) 
            { 
                Console.Write(book.Title + ","); 
            }
            Console.WriteLine();
        }
    }
}
