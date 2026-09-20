using System;

namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //compareTo, contains
            Console.WriteLine("É igual");
            Console.WriteLine(DateTime.DaysInMonth(2025, 3));



            //StringBuilder() ele é um construtor
            // propriedade Length
            //ToLower
            //ToUpper
            //Insert
            //Remove
            //Replace
            //Split
            //Substring
            //LastIndexOf
            //Trim
            //Append
        }
        static bool IsWeekDay(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
    }
}