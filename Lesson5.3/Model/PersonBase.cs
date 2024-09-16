using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3.Model
{
    internal partial class Person
    {
        public partial void Read()
        {
            MessageBox.Show("I am reading");
        }
        public void Move()
        {
            MessageBox.Show("I am moving");
        }
    }
}
