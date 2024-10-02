using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    internal class Building
    {
        public string? BuildingName { get; set; }
        private double height;
        public double Height 
        {
            get=>height ;
            set { if (value > 0) height = value; } 
        }
        private int floors;
        public int Floors
        {
            get => floors;
            set { if (value > 0) floors = value; }
        }
        private double totalArea;
        public double TotalArea
        {
            get => totalArea;
            set { if (value > 0) totalArea = value; }
        }
        public double CalculateVolume()
        {
            return totalArea*Height;
        }
    }
}
