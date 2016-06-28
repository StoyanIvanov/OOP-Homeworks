using System;
using System.Runtime.InteropServices;

namespace Problem10_DateModifier
{
    public class Program
    {
        public static void Main()
        {
            var inputfirstDate = Console.ReadLine();
            var inputsecondDate = Console.ReadLine();

            DateTime firstDate = Convert.ToDateTime(inputfirstDate);
            DateTime secondDate = Convert.ToDateTime(inputsecondDate);
            DateModifier modifyDate=new DateModifier(firstDate,secondDate);
            long result = modifyDate.ReturnDifferentDays();

            Console.WriteLine(result);

        }
    }

    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(DateTime firstDate, DateTime secondDate)
        {
            if (secondDate>firstDate)
            {
                this.firstDate = firstDate;
                this.secondDate = secondDate;
            }
            else
            {
                this.firstDate = secondDate;
                this.secondDate = firstDate;
            }
            
        }

        public long ReturnDifferentDays()
        {
            return (long) ((secondDate - firstDate)).TotalDays;
        }
    }
}
