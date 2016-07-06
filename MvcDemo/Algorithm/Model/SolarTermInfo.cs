using System;

namespace Model
{
    /// <summary> 
    /// 二十四节气表
    /// </summary>
    [Serializable]
    public class SolarTermInfo
    {
        #region Fields

        private int _id;
        private int _year;
        private string _name = string.Empty;
        private DateTime _startTime;
        private DateTime _endTime;
        private DateTime _gregorianTime;
        private string _lunarMonth = string.Empty;
        private string _lunarDay = string.Empty;
        private string _lunarWeek = string.Empty;
        private int _status = 0;
        private DateTime _addTime;

        #endregion

        #region Constructors

        public SolarTermInfo() { }

        public SolarTermInfo(
            int id,
            int year,
            string name,
            DateTime startTime,
            DateTime endTime,
            DateTime gregorianTime,
            string lunarMonth,
            string lunarDay,
            string lunarWeek,
            int status,
            DateTime addTime
        )
        {
            _id = id;
            _year = year;
            _name = name;
            _startTime = startTime;
            _endTime = endTime;
            _gregorianTime = gregorianTime;
            _lunarMonth = lunarMonth;
            _lunarWeek = lunarWeek;
            _lunarDay = lunarDay;
            _status = status;
            _addTime = addTime;
        }

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public DateTime GregorianTime
        {
            get { return _gregorianTime; }
            set { _gregorianTime = value; }
        }

        public string LunarMonth
        {
            get { return _lunarMonth; }
            set { _lunarMonth = value; }
        }

        public string LunarWeek
        {
            get { return _lunarWeek; }
            set { _lunarWeek = value; }
        }

        public string LunarDay
        {
            get { return _lunarDay; }
            set { _lunarDay = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

        #endregion
    }
}
