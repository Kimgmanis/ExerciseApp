using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseApp.Exercise
{
    internal class DateRep
    {
        // Date struct
        public struct Date
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }

            // Constructor
            public Date(int year, int month, int day)
            {
                Year = year;
                Month = month;
                Day = day;
            }

            public bool IsValid()
            {
                try
                {
                    DateTime dt = new DateTime(Year, Month, Day); // Creates dt obj from Year, Month, and Day
                    return true; // valid; was able to create object
                }
                catch
                {
                    return false; // invalid unable to create object
                }
            }

            // Convert date to string
            public override string ToString()
            {
                return $"{Year:D4}-{Month:D2}-{Day:D2}";
            }
        }

        // Ini
        public DateRep() 
        {
            Date date1 = new Date(2023, 2, 17);

            Date date2 = new Date(2023, 2, 29);

            Date date3 = new Date(2023, 13, 1);



            Console.WriteLine("Date 1 is valid? " + date1.IsValid());

            Console.WriteLine("Date 2 is valid? " + date2.IsValid());

            Console.WriteLine("Date 3 is valid? " + date3.IsValid());



            Console.WriteLine("Date 1: " + date1.ToString());

            Console.WriteLine("Date 2: " + date2.ToString());

            Console.WriteLine("Date 3: " + date3.ToString());
        }

    }
}
