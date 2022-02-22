using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace BijBijCup
{
    public static class Assist
    {
        public static string ToShamsi(this DateTime val)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format(@"{0:0000}/{1:00}/{2:00}",
                             pc.GetYear(val),
                             pc.GetMonth(val),
                             pc.GetDayOfMonth(val));
        }
    }
}