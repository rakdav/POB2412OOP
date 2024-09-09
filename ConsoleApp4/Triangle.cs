using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Triangle
    {
        private double a;
        public double A 
        {  
            get { return a; } 
            set {  if(value>0&&Valide(value,b,c)) a = value; } 
        }
        private double b;
        public double B
        {
            get { return b; }
            set { if (value > 0&&Valide(a,value,c)) b = value; }
        }
        private double c;
        public double C
        {
            get { return c; }
            set { if (value > 0&&Valide(a,b,value)) c = value; }
        }
        public Triangle(double _a,double _b,double _c)
        {
            if (Valide(_a, _b, _c))
            {
                a= _a;
                b= _b;
                c= _c;
            };
        }
        private bool Valide(double _a, double _b, double _c)
        {
            if (_a + _b > _c && _a + _c > _b && _c + _b > _a&&_a>0&&_b>0&&_c>0)
            {
                return true;
            }
            return false;
        }
        public double Perimetr()
        {
            return a + b + c;
        }
        public double Area() 
        {
            double pp = Perimetr() / 2;
            return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
        }
        public void Print() 
        {
            Console.WriteLine("Периметр:"+Perimetr() +
                  " Площадь:" + Area());
        }
    }
}
