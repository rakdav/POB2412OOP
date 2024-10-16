using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._1
{
    internal class Student<T>:ICloneable,IComparable
    {
        public string FIO { get; set; }
        public T Group { get; set; }
        private int[] marks=new int[5];
        public Student(string _s,T _g) 
        {
            FIO = _s;
            Group=_g;
            Random random = new Random();
            for (int i = 0; i <marks.Length; i++)
            {
                marks[i]=random.Next(2,6);
            }
        }
        public Student()
        {

        }
        public object Clone()
        {
            //if (Group is int)
            //{
            //    return new Student<int>() { 
            //        FIO= this.FIO,
            //        Group = Group as Int64,
            //        marks = this.marks
            //    };
            //}
            //return new Student<string>()
            //{
            //    FIO = this.FIO,
            //    Group = Group,
            //    marks = this.marks
            //};
            return MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student<T>)
            {
                var student = obj as Student<T>;
                if (this.Group is int)
                {
                    if (int.Parse(Group.ToString()!) >
                        int.Parse(student!.Group!.ToString()!)) return 1;
                    else if (int.Parse(Group.ToString()!) ==
                        int.Parse(student.Group.ToString()!)) return 0;
                    return 0;
                }
                else if (this.Group is string)
                {
                    if (Group.ToString()!.CompareTo(student!.Group) == 1) return 1;
                    else if (Group.ToString()!.CompareTo(student.Group) == 0) return 0;
                    return -1;
                }
            }
            return 0;
        }

        public override string? ToString()
        {
            string res = FIO+" "+Group+" ";
            foreach (var item in marks)
            {
                res += item + " ";
            }
            return res;
        }
    }
}
