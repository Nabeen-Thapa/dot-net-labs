using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbin_Lab_4
{
    internal class _4_7_Time
    {
        class Time
        {
            private int hours;
            private int minutes;
            private int seconds;
            public Time(int hours, int minutes, int seconds)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
                NormalizeTime();
            }
            public Time()
            {
            }
            public void DisplayTime()
            {
                Console.WriteLine($"{this.hours:D2}:{this.minutes:D2}:{this.seconds:D2}");
            }
            public Time AddTime(Time other)
            {
                int newHours = this.hours + other.hours;
                int newMinutes = this.minutes + other.minutes;
                int newSeconds = this.seconds + other.seconds;

                Time result = new Time(newHours, newMinutes, newSeconds);
                result.NormalizeTime();
                return result;
            }

            // Method to subtract one Time object from another
            public Time SubtractTime(Time other)
            {
                int newHours = this.hours - other.hours;
                int newMinutes = this.minutes - other.minutes;
                int newSeconds = this.seconds - other.seconds;

                if (newSeconds < 0)
                {
                    newSeconds += 60;
                    newMinutes--;
                }

                if (newMinutes < 0)
                {
                    newMinutes += 60;
                    newHours--;
                }

                if (newHours < 0)
                {
                    newHours += 24;
                }

                Time result = new Time(newHours, newMinutes, newSeconds);
                return result;
            }

            private void NormalizeTime()
            {
                if (this.seconds >= 60)
                {
                    this.minutes += this.seconds / 60;
                    this.seconds %= 60;
                }

                if (this.minutes >= 60)
                {
                    this.hours += this.minutes / 60;
                    this.minutes %= 60;
                }

                this.hours %= 24;
            }
        }

        class timevalue
        {
            static void Main()
            {

                Time time1 = new Time(7, 37, 20);
                Time time2 = new Time(4, 10, 28);

                Console.Write("Time 1:");
                time1.DisplayTime();
                Console.Write("Time 2:");
                time2.DisplayTime();

                Time sum = time1.AddTime(time2);
                Console.Write("sum of boht time:");
                sum.DisplayTime();

                Time difference = time1.SubtractTime(time2);
                Console.Write("Difference of both time:");
                difference.DisplayTime();
                Console.ReadKey();
            }
        }

    }
}
