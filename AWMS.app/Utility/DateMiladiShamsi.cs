using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWMS.app.Utility
{
    public static class DateMiladiShamsi
    {
        public static string DateMiladi()
        {
            DateTime currentDate = DateTime.Now;
            // نمایش تاریخ میلادی
            //return "تاریخ میلادی: " + currentDate.ToString("yyyy/MM/dd");
            return "Date: " + currentDate.ToString("yyyy/MM/dd");
        }
        public static string DateShamsi()
        {
            DateTime currentDate = DateTime.Now;

            // ایجاد یک نمونه از PersianCalendar
            PersianCalendar persianCalendar = new PersianCalendar();

            // استخراج سال، ماه و روز جلالی
            int persianYear = persianCalendar.GetYear(currentDate);
            int persianMonth = persianCalendar.GetMonth(currentDate);
            int persianDay = persianCalendar.GetDayOfMonth(currentDate);

            // ساخت رشته تاریخ جلالی
            string persianDate = $"{persianYear}/{persianMonth}/{persianDay}";

            // نمایش تاریخ جلالی
            //return "تاریخ جلالی: " + persianDate;
            return "Jalali Date: " + persianDate;
        }


    }
}
