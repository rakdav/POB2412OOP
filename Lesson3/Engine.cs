using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Engine
    {
        private double currentFill;
        public double CurrentFill
        {
            get { return currentFill; }
            set { currentFill = value; }
        }
        public string? Name { get; set; }
        private double volume;
        public double Volume
        {
            get { return volume; }
            set { if (value > 0 && value < 70) volume = value; }
        }
        private double rashod;
        public double Rashod
        {
            get { return rashod; }
            set { if (value > 0 && value < 100) rashod = value; }
        }
        public void AddFill(double vol)
        {
            if (currentFill + vol <= volume)
                currentFill += vol;
            else currentFill = volume;
        }
        public double Way(double path)
        {
            currentFill -= (path / 100) * rashod;
            return (path / 100) * rashod;
        }
        public double CanGo()
        {
            return (currentFill / rashod) * 100;
        }
        public double PrintCurrent()
        {
            return currentFill;
        }
    }
}
