using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnalogueClock2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This app calculates lesser angle in degrees between the analogue clock hours arrow and minutes arrow");

            int hours = GetHours();

            int minutes = GetMinutes();

            int hDeg = ConvertHToDeg(hours, minutes);

            int mDeg = ConvertMToDeg(minutes);

            int angleDiff = CalcAngleDiff(hDeg, mDeg);

            int lesserAngle = FindLesserAngle(angleDiff);

            Console.WriteLine($"\nLesser angle is {lesserAngle} degrees");

            Console.ReadLine();
        }

        private static int GetHours()
        {
            Console.WriteLine("\nPlease enter number of hours (whole number 1-12)");

            int hours;

            while (!int.TryParse(Console.ReadLine(), out hours) || hours < 1 || hours > 12)
            {
                Console.WriteLine("Wrong hours number. It must be the whole number 1-12");
            }

            Console.WriteLine($"{hours} is correct hours number");

            return hours;
        }

        private static int GetMinutes()
        {
            Console.WriteLine("\nPlease enter number of minutes (whole number 0-59)");

            int minutes;

            while (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes > 59)
            {
                Console.WriteLine("Wrong minutes number. It must be the whole number 0-59");
            }

            Console.WriteLine($"{minutes} is correct minutes number");

            return minutes;
        }

        private static int ConvertHToDeg(int hours, int minutes)
        {
            if (hours == 12)
            {
                int hDeg = minutes / 2;
                return hDeg;
            }
            else
            {
                int hDeg = hours * 30 + minutes / 2;
                return hDeg;
            }
        }

        private static int ConvertMToDeg(int minutes)
        {
            int mDeg = minutes * 6;
            return mDeg;
        }

        private static int CalcAngleDiff(int hDeg, int mDeg)
        {
            if (hDeg > mDeg)
            {
                int angleDiff = hDeg - mDeg;
                return angleDiff;
            }
            else
            {
                int angleDiff = mDeg - hDeg;
                return angleDiff;
            }
        }

        private static int FindLesserAngle(int angleDiff)
        {
            if (angleDiff < 180)
            {
                return angleDiff;
            }
            else
            {
                int lesserAngle = 360 - angleDiff;
                return lesserAngle;
            }
        }
    }
}
