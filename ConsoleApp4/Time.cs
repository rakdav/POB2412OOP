using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Time
    {
        private int hour;
        public int Hour
        {
            get { return hour; }
            set { if (value >= 0 && value < 24) hour = value;
                else throw new Exception("Введите корректное значение часа!");
            }
        }
        private int minute;
        public int Minute
        {
            get { return minute; }
            set { if (value >= 0 && value < 60) minute = value;
                else throw new Exception("Введите корректное значение минут!");
            }
        }
        private int second;
        public int Second
        {
            get { return second; }
            set { if (value >= 0 && value < 60) second = value;
                else throw new Exception("Введите корректное значение секунд!");
            }
        }
        public void AddHour(int hours)
        {
            if(hour+hours>=24) Hour = hour+hours-(hour+hours)/24*24;
            else Hour=hour+hours;
        }
        public void AddMinutes(int minutes)
        {
            if (minute + minutes > 60)
            {
                Hour = hour + (minute + minutes) / 60;
                Minute = minute + minutes - (minute+minutes)/60*60;
            }
            else Minute= minute+minutes;
        }
        public void AddSeconds(int seconds)
        {
            TimeOnly dateTime = new TimeOnly(hour, minute, second);
            dateTime=dateTime.Add(TimeSpan.FromSeconds(seconds));
            Hour=dateTime.Hour;
            Minute=dateTime.Minute;
            Second=dateTime.Second;
        }

        public void SubHours(int hours)
        {
            TimeOnly dateTime = new TimeOnly(hour, minute, second);
            dateTime = dateTime.AddHours(-hours);
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
        }
        public void SubMinutes(int minutes)
        {
            TimeOnly dateTime = new TimeOnly(hour, minute, second);
            dateTime = dateTime.AddMinutes(-minutes);
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
        }
        public void SubSeconds(int seconds)
        {
            TimeOnly dateTime = new TimeOnly(hour, minute, second);
            dateTime = dateTime.Add(-TimeSpan.FromSeconds(seconds));
            Hour = dateTime.Hour;
            Minute = dateTime.Minute;
            Second = dateTime.Second;
        }
        public void Print()
        {
            Console.WriteLine(Hour+":"+Minute+":"+Second);
        }
    }
}
