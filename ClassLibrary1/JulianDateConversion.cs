using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ClassLibrary1
{
    public static class JulianDateConversion
    {
        public static string ConverttoYYYYDDD(DateTime Date)
        {
            JulianCalendar calendar = new JulianCalendar();

            var dateInJulian = calendar.ToDateTime(Date.Year, Date.Month, Date.Day, Date.Hour, Date.Minute, Date.Second, Date.Millisecond);
            var stringResult = string.Format("{0}{1}", dateInJulian.ToString("yyyy"), dateInJulian.DayOfYear);

            return (stringResult);
        }
    }
}
