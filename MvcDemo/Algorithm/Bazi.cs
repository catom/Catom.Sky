using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Algorithm
{
    /// <summary>
    ///  算法条件类
    ///     求出生辰八字，为算法提供八字的输入条件
    /// </summary>
    public class BaZi
    {
        #region 老数据

        public static int nYear;
        public static int nMonth;
        public static int nDay;
        public static int nHour;
        public static int nMinute;
        public static int JieQiMonth;
        public static string PrevJQYear;
        public static string PrevJQMonth;
        public static string PrevJQDay;
        public static string PrevJQHour;
        public static string PrevJQMinute;
        public static string NextJQYear;
        public static string NextJQMonth;
        public static string NextJQDay;
        public static string NextJQHour;
        public static string NextJQMinute;
        public static string nTianGan;
        public static string yTianGan;
        public static string rTianGan;
        public static string sTianGan;
        public static string nDiZhi;
        public static string yDiZhi;
        public static string rDiZhi;
        public static string sDiZhi;

        public static string rizhu;
        public static int nTianGanID;
        public static int yTianGanID;
        public static int rTianGanID;

        public static string PrevJieQi;
        public static string NextJieQi;
        public static string[] TianGan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
        public static string[] DiZhi = { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        public static string[] JieQi = { };
        #endregion

        #region Fields

        // 用于获取数据库中的参数
        //private readonly SolarTerm _bll = new SolarTerm();

        // 阳历的当年与上一年的二十四节气表
        private List<SolarTermInfo> _solarTerms;

        public List<SolarTermInfo> SolarTerms
        {
            get
            {
                return _solarTerms ; /*?? (_solarTerms = _bll.GetModelList(GregorianYear)) */;
            }
        }

        // 生辰的阳历生日的年月日
        public int LunarYear;
        public int LunarMonth;
        public int LunarDay;

        // 生辰的阴历年月日
        public int GregorianYear;
        public int GregorianMonth;
        public int GregorianDay;

        // 生辰的时分秒部分
        public int BirthHour;
        public int BirthMinute;
        public int BirthSecond;

        // 八字：生辰的年月日时干支（四柱）
        public string YearGan;
        public string YearZhi;
        public string MonthGan;
        public string MonthZhi;
        public string DayGan;
        public string DayZhi;
        public string TimeGan;
        public string TimeZhi;

        // 生辰的上下节气
        public string PrevSolarTerm;
        public string NextSolarTerm;

        // 自测错误消息
        private string _errorMessage;

        #endregion

        #region Constructors

        public BaZi() { }

        /// <summary>
        ///  日期格式为 yyyy-MM-dd hh:mm:ss 或者 yyyy/MM/dd hh:mm:ss
        /// </summary>
        /// <param name="birthday">生辰日期</param>
        /// <param name="birthdayType">日期类型：农历或阳历</param>
        public BaZi(string birthday, BirthdayType birthdayType = BirthdayType.阳历)
        {
            var arr1 = birthday.Split(' '); // 切分 Date 和 Time
            var arr2 = arr1[0].IndexOf('-') > 0 ? arr1[0].Split('-') : arr1[0].Split('/'); // 切分年月日

            if (birthdayType == BirthdayType.阳历)
            {
                GregorianYear = int.Parse(arr2[0]);
                GregorianMonth = int.Parse(arr2[1]);
                GregorianDay = int.Parse(arr2[2]);
            }
            else
            {
                LunarYear = int.Parse(arr2[0]);
                LunarMonth = int.Parse(arr2[1]);
                LunarDay = int.Parse(arr2[2]);
            }

            var timeArr = arr1[1].Split(':');
            BirthHour = int.Parse(timeArr[0]);
            BirthMinute = int.Parse(timeArr[1]);
            BirthSecond = int.Parse(timeArr[2]);
        }

        public BaZi(int year, int month, int day, int hour, int minute, int second, BirthdayType birthdayType = BirthdayType.阳历)
        {
            if (birthdayType == BirthdayType.阳历)
            {
                GregorianYear = year;
                GregorianMonth = month;
                GregorianDay = day;
            }
            else
            {
                LunarYear = year;
                LunarMonth = month;
                LunarDay = day;
            }

            BirthHour = hour;
            BirthMinute = minute;
            BirthSecond = second;
        }

        #endregion

        #region 八字四柱算法

        public void CalcBazi()
        {
            try
            {
                CalcYearGanzhi();
                CalcMonthGanZhi();
                CalcDayGanzhi();
                CalcTimeGanZhi();
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }

        /// <summary>
        /// 获取年干支
        /// </summary>
        private void CalcYearGanzhi()
        {
            LunarYear = GregorianYear;

            if (GregorianMonth == 1)
            {
                LunarYear--;
            }
            // 立春只可能在阳历2月。
            // * 注：年份划分以农历的立春划分，而不是以农历春节划分！！
            if (GregorianMonth == 2)
            {
                // 出生的阳历日期
                var gregorianBirthday = new DateTime(GregorianYear, GregorianMonth, GregorianDay, BirthHour, BirthMinute, BirthSecond);

                // 农历年份划分条件！！
                var model = SolarTerms.First(st => st.Year == GregorianYear && st.Name.Contains("立春"));

                if (gregorianBirthday <= model.StartTime)
                {
                    LunarYear--;
                }
            }

            var index1 = LunarYear % 10 < 4 ? LunarYear % 10 + 10 : LunarYear % 10;
            var index2 = LunarYear % 12 < 4 ? LunarYear % 12 + 12 : LunarYear % 12;

            YearGan = FortuneConstants.Tiangan[index1 - 4];
            YearZhi = FortuneConstants.Dizhi[index2 - 4];
        }

        /// <summary>
        /// 计算月干支；
        /// 计算农历月份；
        /// </summary>
        private void CalcMonthGanZhi()
        {
            var mDate = new DateTime(GregorianYear, GregorianMonth, GregorianDay, BirthHour, BirthMinute, BirthSecond);

            // 求出农历月份
            var currSt = SolarTerms.First(st => st.StartTime <= mDate && st.EndTime > mDate);
            var mName = currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 2) : currSt.LunarMonth.Substring(0, 1);
            LunarMonth = FortuneConstants.DicLunarMonth[mName];
            var solarTermMonth = FortuneConstants.DicSolarTermMonth[currSt.Name];

            // 求出上下节气
            var prevSt = SolarTerms.First(st => st.StartTime > mDate.AddDays(-16));
            var nextSt = SolarTerms.Where(st => st.EndTime < mDate.AddDays(16)).OrderByDescending(st => st.EndTime).First();

            // NTODO 此处仍有问题！
            PrevSolarTerm = string.Format("{0}：{1}年{2}{3} {4}", prevSt.Name, prevSt.Year, currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 3) : currSt.LunarMonth.Substring(0, 2),
                prevSt.LunarDay, prevSt.StartTime.ToString("hh时MM分"));
            NextSolarTerm = string.Format("{0}：{1}年{2}{3} {4}", nextSt.Name, nextSt.Year, currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 3) : currSt.LunarMonth.Substring(0, 2),
                nextSt.LunarDay, nextSt.StartTime.ToString("hh时MM分"));

            // 算月干
            switch (YearGan)
            {
                case "甲":
                    MonthGan = CalcMonthGan(0, solarTermMonth);
                    break;
                case "乙":
                    MonthGan = CalcMonthGan(1, solarTermMonth);
                    break;
                case "丙":
                    MonthGan = CalcMonthGan(2, solarTermMonth);
                    break;
                case "丁":
                    MonthGan = CalcMonthGan(3, solarTermMonth);
                    break;
                case "戊":
                    MonthGan = CalcMonthGan(4, solarTermMonth);
                    break;
                case "己":
                    MonthGan = CalcMonthGan(5, solarTermMonth);
                    break;
                case "庚":
                    MonthGan = CalcMonthGan(6, solarTermMonth);
                    break;
                case "辛":
                    MonthGan = CalcMonthGan(7, solarTermMonth);
                    break;
                case "壬":
                    MonthGan = CalcMonthGan(8, solarTermMonth);
                    break;
                case "癸":
                    MonthGan = CalcMonthGan(9, solarTermMonth);
                    break;
            }

            // 算月支
            MonthZhi = FortuneConstants.Dizhi[(solarTermMonth + 1) % 12];
        }

        /// <summary>
        /// 根据年干计算出月干
        /// </summary>
        /// <param name="yearGanId">年干下标</param>
        /// <param name="solarTermMonth">节气下标</param>
        private string CalcMonthGan(int yearGanId, int solarTermMonth)
        {
            var monthGanId = yearGanId * 2 + solarTermMonth + 1;
            return FortuneConstants.Tiangan[monthGanId % 10];
        }

        /// <summary>
        /// 获取日干日支
        /// </summary>
        private void CalcDayGanzhi()
        {
            var baseDate = new DateTime(1899, 12, 22); //起始日
            var qiguaDate = new DateTime(GregorianYear, GregorianMonth, GregorianDay);
            var ts = qiguaDate - baseDate;

            var i = ts.Days % 60;
            DayGan = FortuneConstants.Tiangan[i % 10];
            DayZhi = FortuneConstants.Dizhi[i % 12];
        }

        /// <summary>
        /// 获取时支
        /// </summary>
        private void CalcTimeGanZhi()
        {
            switch (DayGan)
            {
                case "甲":
                case "己":
                    TimeGan = CalcTimeGan(0);
                    break;
                case "乙":
                case "庚":
                    TimeGan = CalcTimeGan(2);
                    break;
                case "丙":
                case "辛":
                    TimeGan = CalcTimeGan(4);
                    break;
                case "丁":
                case "壬":
                    TimeGan = CalcTimeGan(6);
                    break;
                default:
                    TimeGan = CalcTimeGan(8);
                    break;
            }

            if (BirthHour == 23 || BirthHour == 0)
            {
                TimeZhi = FortuneConstants.Dizhi[0];
            }
            if (BirthHour == 1 || BirthHour == 2)
            {
                TimeZhi = FortuneConstants.Dizhi[1];
            }
            if (BirthHour == 3 || BirthHour == 4)
            {
                TimeZhi = FortuneConstants.Dizhi[2];
            }
            if (BirthHour == 5 || BirthHour == 6)
            {
                TimeZhi = FortuneConstants.Dizhi[3];
            }
            if (BirthHour == 7 || BirthHour == 8)
            {
                TimeZhi = FortuneConstants.Dizhi[4];
            }
            if (BirthHour == 9 || BirthHour == 10)
            {
                TimeZhi = FortuneConstants.Dizhi[5];
            }
            if (BirthHour == 11 || BirthHour == 12)
            {
                TimeZhi = FortuneConstants.Dizhi[6];
            }
            if (BirthHour == 13 || BirthHour == 14)
            {
                TimeZhi = FortuneConstants.Dizhi[7];
            }
            if (BirthHour == 15 || BirthHour == 16)
            {
                TimeZhi = FortuneConstants.Dizhi[8];
            }
            if (BirthHour == 17 || BirthHour == 18)
            {
                TimeZhi = FortuneConstants.Dizhi[9];
            }
            if (BirthHour == 19 || BirthHour == 20)
            {
                TimeZhi = FortuneConstants.Dizhi[10];
            }
            if (BirthHour == 21 || BirthHour == 22)
            {
                TimeZhi = FortuneConstants.Dizhi[11];
            }
        }

        /// <summary>
        /// 获取时干
        /// </summary>
        private string CalcTimeGan(int dayGanId)
        {
            var timeGan = string.Empty;
            switch (BirthHour)
            {
                case 23:
                case 0:
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 1:
                case 2:
                    dayGanId += 1;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 3:
                case 4:
                    dayGanId += 2;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 5:
                case 6:
                    dayGanId += 3;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 7:
                case 8:
                    dayGanId += 4;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 9:
                case 10:
                    dayGanId += 5;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 11:
                case 12:
                    dayGanId += 6;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 13:
                case 14:
                    dayGanId += 7;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 15:
                case 16:
                    dayGanId = 8 + dayGanId;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 17:
                case 18:
                    dayGanId += 9;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 19:
                case 20:
                    dayGanId += 10;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
                case 21:
                case 22:
                    dayGanId += 11;
                    dayGanId = dayGanId > 9 ? (dayGanId - 10) : dayGanId;
                    timeGan = FortuneConstants.Tiangan[dayGanId];
                    break;
            }

            return timeGan;
        }

        #endregion

        #region Methods

        public override string ToString()
        {

            return string.IsNullOrEmpty(_errorMessage) ?
                string.Format("{0}{1} {2}{3} {4}{5} {6}{7}", YearGan, YearZhi, MonthGan, MonthZhi, DayGan, DayZhi, TimeGan, TimeZhi) :
                _errorMessage;
        }

        #endregion

    }

    public enum BirthdayType
    {
        阳历 = 1,
        农历 = 2
    }
}