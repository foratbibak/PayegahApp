using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            if (value == DateTime.MinValue || value < new DateTime(622, 3, 22) || value > new DateTime(9999, 12, 31))
                return "--"; // یا "تاریخ ثبت نشده"
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                pc.GetDayOfMonth(value).ToString("00") + " "+
                pc.GetHour(value).ToString("00") + ":" +
                pc.GetMinute(value).ToString("00") + ":" +
                pc.GetSecond(value).ToString("00");

        }

        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
