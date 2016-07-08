using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Algorithm
{
    /// <summary>
    ///  八字算法类
    ///     使用节气月份的方法算；
    /// </summary>
    public class Bazi
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

        #region Fields & Properties

        //private static readonly SolarTerm Bll = new SolarTerm();

        // 阳历的当年与上一年的二十四节气表
        private IList<SolarTermInfo> _solarTerms;

        private readonly BirthdateInfo _birthdate;

        // 生辰八字
        public string YearTiangan;
        public string YearDizhi;
        public string MonthTiangan;
        public string MonthDizhi;
        public string DayTiangan;
        public string DayDizhi;
        public string TimeTiangan;
        public string TimeDizhi;

        #endregion

        #region

        public Bazi(BirthdateInfo birthdate)
        {
            _birthdate = birthdate;
        }

        #endregion

        #region 八字四柱算法

        public void CalcBazi()
        {
            CalcYearGanzhi();
            CalcMonthGanZhi();
            CalcDayGanzhi();
            CalcTimeGanZhi();
        }

        /// <summary>
        /// 获取年干支
        /// </summary>
        private void CalcYearGanzhi()
        {
            var yearIndex = _birthdate.GregorianYear;

            if (_birthdate.GregorianMonth == 1)
            {
                yearIndex--;
            }
            // 立春只可能在阳历2月。
            // * 注：年份划分以农历的立春划分，而不是以农历春节划分！！
            if (_birthdate.GregorianMonth == 2)
            {
                // 出生的阳历日期
                var gregorianBirthday = new DateTime(_birthdate.GregorianYear, _birthdate.GregorianMonth, _birthdate.GregorianDay, _birthdate.BirthHour, _birthdate.BirthMinute, _birthdate.BirthSecond);

                // 农历年份划分条件！！
                //_solarTerms =new List<SolarTermInfo>();//Bll.GetModelList(_birthdate.GregorianYear); /* 加载相关年份的节气表 */
                var model = _solarTerms.First(st => st.StartTime.Year == _birthdate.GregorianYear && st.Name.Contains("立春"));

                if (gregorianBirthday <= model.StartTime)
                {
                    yearIndex--;
                }
            }

            var index1 = yearIndex % 10 < 4 ? yearIndex % 10 + 10 : yearIndex % 10;
            var index2 = yearIndex % 12 < 4 ? yearIndex % 12 + 12 : yearIndex % 12;

            YearTiangan = FortuneConstants.Tiangan[index1 - 4];
            YearDizhi = FortuneConstants.Dizhi[index2 - 4];
        }

        /// <summary>
        /// 计算月干支；
        /// 计算农历月份；
        /// </summary>
        private void CalcMonthGanZhi()
        {
            var mDate = new DateTime(_birthdate.GregorianYear, _birthdate.GregorianMonth, _birthdate.GregorianDay, _birthdate.BirthHour, _birthdate.BirthMinute, _birthdate.BirthSecond);

            // 求出节气月份
            //_solarTerms = _solarTerms ?? (_solarTerms = Bll.GetModelList(_birthdate.GregorianYear));
            var currSt = _solarTerms.First(st => st.StartTime <= mDate && st.EndTime > mDate);
            var mName = currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 2) : currSt.LunarMonth.Substring(0, 1);
            _birthdate.LunarMonth = FortuneConstants.DicLunarMonth[mName];
            var solarTermMonth = FortuneConstants.DicSolarTermMonth[currSt.Name];

            // 求出上下节气
            var prevSt = _solarTerms.First(st => st.StartTime > mDate.AddDays(-16));
            var nextSt = _solarTerms.Where(st => st.EndTime < mDate.AddDays(16)).OrderByDescending(st => st.EndTime).First();

            // NTODO 此处仍有问题！
            _birthdate.PrevSolarTerm = string.Format("{0}：{1}年{2}{3} {4}", prevSt.Name, prevSt.Year, currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 3) : currSt.LunarMonth.Substring(0, 2),
                prevSt.LunarDay, prevSt.StartTime.ToString("hh时MM分"));
            _birthdate.NextSolarTerm = string.Format("{0}：{1}年{2}{3} {4}", nextSt.Name, nextSt.Year, currSt.LunarMonth.Contains("闰") ? currSt.LunarMonth.Substring(0, 3) : currSt.LunarMonth.Substring(0, 2),
                nextSt.LunarDay, nextSt.StartTime.ToString("hh时MM分"));

            // 算月干
            switch (YearTiangan)
            {
                case "甲":
                    MonthTiangan = CalcMonthGan(0, solarTermMonth);
                    break;
                case "乙":
                    MonthTiangan = CalcMonthGan(1, solarTermMonth);
                    break;
                case "丙":
                    MonthTiangan = CalcMonthGan(2, solarTermMonth);
                    break;
                case "丁":
                    MonthTiangan = CalcMonthGan(3, solarTermMonth);
                    break;
                case "戊":
                    MonthTiangan = CalcMonthGan(4, solarTermMonth);
                    break;
                case "己":
                    MonthTiangan = CalcMonthGan(5, solarTermMonth);
                    break;
                case "庚":
                    MonthTiangan = CalcMonthGan(6, solarTermMonth);
                    break;
                case "辛":
                    MonthTiangan = CalcMonthGan(7, solarTermMonth);
                    break;
                case "壬":
                    MonthTiangan = CalcMonthGan(8, solarTermMonth);
                    break;
                case "癸":
                    MonthTiangan = CalcMonthGan(9, solarTermMonth);
                    break;
            }

            // 算月支
            MonthDizhi = FortuneConstants.Dizhi[(solarTermMonth + 1) % 12];
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
            var qiguaDate = new DateTime(_birthdate.GregorianYear, _birthdate.GregorianMonth, _birthdate.GregorianDay);
            var ts = qiguaDate - baseDate;

            var i = ts.Days % 60;
            DayTiangan = FortuneConstants.Tiangan[i % 10];
            DayDizhi = FortuneConstants.Dizhi[i % 12];
        }

        /// <summary>
        /// 获取时支
        /// </summary>
        private void CalcTimeGanZhi()
        {
            switch (DayTiangan)
            {
                case "甲":
                case "己":
                    TimeTiangan = CalcTimeGan(0, _birthdate.BirthHour);
                    break;
                case "乙":
                case "庚":
                    TimeTiangan = CalcTimeGan(2, _birthdate.BirthHour);
                    break;
                case "丙":
                case "辛":
                    TimeTiangan = CalcTimeGan(4, _birthdate.BirthHour);
                    break;
                case "丁":
                case "壬":
                    TimeTiangan = CalcTimeGan(6, _birthdate.BirthHour);
                    break;
                default:
                    TimeTiangan = CalcTimeGan(8, _birthdate.BirthHour);
                    break;
            }

            if (_birthdate.BirthHour == 23 || _birthdate.BirthHour == 0)
            {
                TimeDizhi = FortuneConstants.Dizhi[0];
            }
            if (_birthdate.BirthHour == 1 || _birthdate.BirthHour == 2)
            {
                TimeDizhi = FortuneConstants.Dizhi[1];
            }
            if (_birthdate.BirthHour == 3 || _birthdate.BirthHour == 4)
            {
                TimeDizhi = FortuneConstants.Dizhi[2];
            }
            if (_birthdate.BirthHour == 5 || _birthdate.BirthHour == 6)
            {
                TimeDizhi = FortuneConstants.Dizhi[3];
            }
            if (_birthdate.BirthHour == 7 || _birthdate.BirthHour == 8)
            {
                TimeDizhi = FortuneConstants.Dizhi[4];
            }
            if (_birthdate.BirthHour == 9 || _birthdate.BirthHour == 10)
            {
                TimeDizhi = FortuneConstants.Dizhi[5];
            }
            if (_birthdate.BirthHour == 11 || _birthdate.BirthHour == 12)
            {
                TimeDizhi = FortuneConstants.Dizhi[6];
            }
            if (_birthdate.BirthHour == 13 || _birthdate.BirthHour == 14)
            {
                TimeDizhi = FortuneConstants.Dizhi[7];
            }
            if (_birthdate.BirthHour == 15 || _birthdate.BirthHour == 16)
            {
                TimeDizhi = FortuneConstants.Dizhi[8];
            }
            if (_birthdate.BirthHour == 17 || _birthdate.BirthHour == 18)
            {
                TimeDizhi = FortuneConstants.Dizhi[9];
            }
            if (_birthdate.BirthHour == 19 || _birthdate.BirthHour == 20)
            {
                TimeDizhi = FortuneConstants.Dizhi[10];
            }
            if (_birthdate.BirthHour == 21 || _birthdate.BirthHour == 22)
            {
                TimeDizhi = FortuneConstants.Dizhi[11];
            }
        }

        /// <summary>
        /// 获取时干
        /// </summary>
        private string CalcTimeGan(int dayGanId, int hour)
        {
            var timeGan = string.Empty;
            switch (hour)
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

        #region 工具方法

        /// <summary>
        ///  输出格式化的八字
        /// </summary>
        /// <param name="birthdate"></param>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", YearTiangan, YearDizhi, MonthTiangan, MonthDizhi, DayTiangan, DayDizhi, TimeTiangan, TimeDizhi);
        }

        #endregion
    }

}