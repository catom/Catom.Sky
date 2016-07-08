
namespace Algorithm
{
    /// <summary>
    /// 生辰日期，基本输入信息
    /// </summary>
    public class BirthdateInfo
    {
        #region Fields

        // 阳历生日
        public int GregorianYear;
        public int GregorianMonth;
        public int GregorianDay;

        // 农历生日
        public int LunarYear;
        public int LunarMonth;
        public int LunarDay;

        // 生辰的时分秒部分
        public int BirthHour;
        public int BirthMinute;
        public int BirthSecond;

        //// 生辰八字
        //public string YearTiangan;
        //public string YearDizhi;
        //public string MonthTiangan;
        //public string MonthDizhi;
        //public string DayTiangan;
        //public string DayDizhi;
        //public string TimeTiangan;
        //public string TimeDizhi;

        // 春节日期（阳历年份）
        //public DateTime SpringFestivalDate;

        // 节前年份号

        // 节后年份号

        // 五行方位

        // 生肖

        // 生辰的上下节气
        public string PrevSolarTerm;
        public string NextSolarTerm;

        #endregion

        #region Constructors

        public BirthdateInfo() { }

        /// <summary>
        ///  日期格式为 yyyy-MM-dd hh:mm:ss 或者 yyyy/MM/dd hh:mm:ss
        /// </summary>
        /// <param name="birthday">生辰日期</param>
        /// <param name="birthdateType">日期类型：农历或阳历</param>
        public BirthdateInfo(string birthday, BirthdateType birthdateType = BirthdateType.阳历)
        {
            var arr1 = birthday.Split(' '); // 切分 Date 和 Time
            var arr2 = arr1[0].IndexOf('-') > 0 ? arr1[0].Split('-') : arr1[0].Split('/'); // 切分年月日

            if (birthdateType == BirthdateType.阳历)
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

        public BirthdateInfo(int year, int month, int day, int hour, int minute, int second, BirthdateType birthdateType = BirthdateType.阳历)
        {
            if (birthdateType == BirthdateType.阳历)
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

        #region Methods

        
        #endregion

    }

    public enum BirthdateType
    {
        阳历 = 1,
        农历 = 2
    }
}