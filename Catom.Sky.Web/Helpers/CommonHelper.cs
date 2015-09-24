using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Practices.Unity;
using Catom.Sky.Component.Data;
using Catom.Sky.Component.Util;
using Microsoft.VisualBasic;

namespace Catom.Sky.Web.Helpers
{
    public enum DateInterval
    {
        Second, Minute, Hour, Day, Week, Month, Quarter, Year
    }

    public enum SearchType
    {
        Exact,
        Advanced,
        Excel,
        Collected
    }

    public enum TeacherTargetType
    {
        Teacher,
        Assistant = 1
    }

    public static class DateExtension
    {
        public static int DayOfWeek(this DateTime dt)
        {
            //今天是星期几
            int iNowOfWeek = (int)dt.DayOfWeek;
            return iNowOfWeek + 1;
        }

        public static string DayOfWeekName(this DateTime dt)
        {
            int iNowOfWeek = (int)dt.DayOfWeek;
            string[] names = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", };
            return names[iNowOfWeek];
        }
    }

    public class CommonHelper
    {
        public static long DateDiff(DateInterval interval, DateTime startDate, DateTime endDate)
        {
            long lngDateDiffValue = 0;
            switch (interval)
            {
                case DateInterval.Second:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Second, startDate, endDate);
                    break;
                case DateInterval.Minute:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Minute, startDate, endDate);
                    break;
                case DateInterval.Hour:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Hour, startDate, endDate);
                    break;
                case DateInterval.Day:
                    lngDateDiffValue = (endDate.Date - startDate.Date).Days;
                    break;
                case DateInterval.Week:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Weekday, startDate, endDate);
                    break;
                case DateInterval.Month:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Month, startDate, endDate);
                    break;
                case DateInterval.Quarter:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Quarter, startDate, endDate);
                    break;
                case DateInterval.Year:
                    lngDateDiffValue = DateAndTime.DateDiff(Microsoft.VisualBasic.DateInterval.Year, startDate, endDate);
                    break;
            }
            return (lngDateDiffValue);
        }



        /// <summary>
        /// 返回action地址,特别注意字符串必为小写
        /// </summary>
        /// <returns></returns>
        public static string GetRequestUrl()
        {
            var url = HttpContext.Current.Request.Url.AbsolutePath;
            var arr = url.Split('/');
            var pageName = "";
            if (arr.Length > 2)
            {
                pageName = arr[2].ToLower();
            }
            return pageName;
        }


        public static string MD5(string convertString)
        {
            return convertString.Md5String();
        }

        public static bool IsiDevice
        {
            get { return HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].IndexOf("iPhone") > 0; }
        }

        public static bool IsiPhone
        {
            get { return HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].IndexOf("iPhone") > 0; }
        }

        public static bool IsiPad
        {
            get { return HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].IndexOf("iPad") > 0; }
        }

        public static bool IsAndroid
        {
            get { return HttpContext.Current.Request.ServerVariables["HTTP_USER_AGENT"].IndexOf("Android") > 0; }
        }

    }
}
