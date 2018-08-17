using System;

namespace CG6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user for the date they were born.
            //Display the name of the day(ie Thursday) and the name of the
            //day their next birthday will be on.Finally, display their zodiac
            //symbol and a fake fortune for them.

            Console.WriteLine("Please enter your birthdate as MM/DD/YYYY");
            //string birthdate = Console.ReadLine();

            DateTime birthdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("You were born on a " + birthdate.DayOfWeek);
            birthdate = new DateTime(DateTime.Now.Year, birthdate.Month, birthdate.Day);

            if (DateTime.Now.CompareTo(birthdate) <= 0)
            {
                birthdate = new DateTime(DateTime.Now.Year + 1, birthdate.Month, birthdate.Day);
            }

            Console.WriteLine("Your next birthday will be on a " + birthdate.DayOfWeek);

            if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 1, 20), new DateTime(birthdate.Year, 2, 18)))
            {
                Console.WriteLine("Your Zodiac sign is Aquarius. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 2, 19), new DateTime(birthdate.Year, 3, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Pisces. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 3, 21), new DateTime(birthdate.Year, 4, 19)))
            {
                Console.WriteLine("Your Zodiac sign is Aries . According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 4, 20), new DateTime(birthdate.Year, 5, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Taurus. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 5, 21), new DateTime(birthdate.Year, 6, 20)))
            {
                Console.WriteLine("Your Zodiac sign is Gemini. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 6, 21), new DateTime(birthdate.Year, 7, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Cancer. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 7, 23), new DateTime(birthdate.Year, 8, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Leo. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 8, 23), new DateTime(birthdate.Year, 9, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Virgo. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 9, 23), new DateTime(birthdate.Year, 10, 22)))
            {
                Console.WriteLine("Your Zodiac sign is Libra. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 10, 23), new DateTime(birthdate.Year, 11, 21)))
            {
                Console.WriteLine("Your Zodiac sign is Scorpio. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }
            else if (DateIsBetween(birthdate, new DateTime(birthdate.Year, 11, 22), new DateTime(birthdate.Year, 12, 21)))
            {
                Console.WriteLine("Your Zodiac sign is Sagittarius. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            }

            else
            {
                Console.WriteLine("Your Zodiac sign is Capricorn. According to your horoscope, " +
                    "You are going to come into a lot of money today!");
            } 

            Console.ReadLine();

        }
        /// <summary>
        /// Compares if date is between the two dates provided.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>True if date is between stat and end date</returns>
        private static bool DateIsBetween(DateTime date, DateTime start, DateTime end)
        {
            if (date >= start && date <= end)
            {
                return true;
            }
            return false;

            
        }
    }
}
