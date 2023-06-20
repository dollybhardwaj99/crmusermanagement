using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Infrastructure.LeadManagement.Implementation.Common
{
    public static class Extension
    {
        public static DateTime IndianTime(this DateTime DiffDT)
        {
            DateTime utc = DateTime.UtcNow;
            DateTime temp = new DateTime(utc.Ticks, DateTimeKind.Utc);
            DateTime ist = TimeZoneInfo.ConvertTimeFromUtc(temp, TimeZoneInfo.FindSystemTimeZoneById("India Standard Time"));
            return ist;
        }

        public static DateTime ConvertStringToDate(this string  str)
        { 
            if (str.ToLower().Contains('-')) 
            {
                return DateTime.ParseExact(str, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            else if (str.ToLower().Contains('.'))
            {
                return DateTime.ParseExact(str, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }

            else
            {
                return DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}
