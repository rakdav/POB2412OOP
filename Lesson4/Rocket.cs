using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public enum TypeOfFuel
    {
        Жидкое,
        Гелиобразное,
        Твердое,
        Гибридное,
        Ядерное
    }
    internal class Rocket
    {
        private TypeOfFuel typeFuel;
        public TypeOfFuel TypeFuel
        {
            get { return typeFuel; }
            set { if (Enum.IsDefined(typeof(TypeOfFuel), value)) typeFuel = value;
                else Console.WriteLine("Такого топлива нет");
            }
        }
        private double volume1;
        public double Volume1
        {
            get { return volume1; }
            set { if (value > 0) volume1 = value; }
        }
        private double volume2;
        public double Volume2
        {
            get { return volume2; }
            set { if (value > 0) volume2 = value; }
        }
        private double volume3;
        public double Volume3
        {
            get { return volume3; }
            set { if (value > 0) volume3 = value; }
        }
        private double speed1;
        public double Speed1
        {
            get { return speed1; }
            set { if (value > 0) speed1= value; }
        }
        private double speed2;
        public double Speed2
        {
            get { return speed2; }
            set { if (value > 0) speed2 = value; }
        }
        private double speed3;
        public double Speed3
        {
            get { return speed3; }
            set { if (value > 0) speed3 = value; }
        }
        private double time1;
        public double Time1
        {
            get { return time1; }
            set { if (value > 0) time1 = value; }
        }
        private double time2;
        public double Time2
        {
            get { return time2; }
            set { if (value > 0) time2 = value; }
        }
        private double time3;
        public double Time3
        {
            get { return time3; }
            set { if (value > 0) time3 = value; }
        }

        
        public double SpeedTime(double time)
        {
            if (time <= time1) return (speed1 / time1) * time;
            else if (time > time1 && time <= time2)
                return ((speed2 - speed1) / (time2 - time1)) * time;
            else if (time > time2 && time <= time3)
                return ((speed3 - speed2) / (time3 - time2)) * time;
            return speed3;
        }
        public double Time()
        {
            return time1+time2+time3;
        }
        public int NumberStep(double time)
        {
            if (time <= time1) return 1;
            else if (time > time1 && time <= time1+time2)
                return 2;
            else if (time > time1+time2 && time <= time1+time2+time3)
                return 3;
            return -1;
        }
    }
}
