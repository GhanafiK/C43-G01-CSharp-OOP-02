using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C__OOP_02
{
    internal class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }


        public void SortEmployee()
        {

        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
