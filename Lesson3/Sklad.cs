using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Sklad
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { if (value > 0) number = value;
                else throw new Exception("Введите правильный номер!");
            }
        }
        private string? fio;
        public string? Fio 
        {
            get { return fio; }
            set { fio = value; }
        }
        private double maxVolume;
        public double MaxVolume
        {
            get { return maxVolume; }
            set { if (value > 0) maxVolume = value;
                else throw new Exception("Введите правильный объем!");
            }
        }
        private double current;
        public double Current
        {
            get { return current; }
            set
            {
                if (value > maxVolume - current)
                {
                    current = maxVolume;
                    Console.WriteLine("Склад перегружен!");
                }
                else if (current + value < 0)
                {
                    Console.WriteLine("Недостаток на складе!");
                }
                else current += value;
            }
        }
        public void Add(double volume)
        {
            Current = volume;
        }
        public void Sub(double volume)
        {
            Current = -volume;
        }
        public void Print()
        {
            Console.WriteLine($"Можно ввести {maxVolume-current:F2}. В наличиии {current:F2}");
        }
    }
}
