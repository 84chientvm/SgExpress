using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utils
{
    public interface ITimestampUtil
    {
        DateTime ConvertToDatetime(double milliseconds);
    }

    public class TimestampUtil : ITimestampUtil
    {
        public DateTime ConvertToDatetime(double milliseconds)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime();
            return milestones.AddMilliseconds(milliseconds);
        }
    }

    public class TimestampStaicClass
    {
        public static DateTime ConvertToDatetime(double? milliseconds)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0);

            if(milliseconds == null || milliseconds <= 0)
            {
                return milestones;
            }

            return milestones.AddMilliseconds((double)milliseconds).ToLocalTime();
        }
        public static double ConvertDateLocalTimeToTimeStamp(DateTime datetime)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime();
            return (datetime - milestones).TotalMilliseconds;
        }
        public static double ConvertTotimestamp(DateTime date)
        {
            DateTime milestones = new DateTime(1970, 1, 1, 0, 0, 0);

            var Timespan = (date - milestones).TotalMilliseconds;

            return Timespan;
        }

        public static int id = 1;
        public static DateTime maxDay = DateTime.Parse("11/04/2021").ToLocalTime();
        public static string CustomId(DateTime date)
        {
            if (date.Date > maxDay.Date)
            {
                maxDay = date;
                id = 1;
                return "000" + id.ToString();
            }

            id = id+1;

            if(id < 10)
            {
                return "000" + id.ToString();
            }
            else if (id < 100)
            {
                return "00" + id.ToString();
            }
            else if(id < 1000)
            {
                return "0" + id.ToString();
            }
            else
            {
                return id.ToString();
            }

           
        }

        public static string ConvertToString(DateTime date)
        {
            string timeString = date.ToString("yyyy/MM/dd");

            return timeString;
        }
    }
   
}
