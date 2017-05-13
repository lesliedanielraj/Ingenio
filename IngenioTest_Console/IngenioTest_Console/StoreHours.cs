using System;
using System.Text;

namespace IngenioTest_Console
{
    public enum DayofWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum StoreStatus
    {
        Closed
    }

    public class StoreHours
    {
        private DayofWeek _weekDay;
        private TimeSpan _startTime;
        private TimeSpan _endTime;
        private StoreStatus _sStatus;

        public StoreHours(DayofWeek weekDay, TimeSpan startTime, TimeSpan endTime)
        {
            this._weekDay = weekDay;
            this._startTime = startTime;
            this._endTime = endTime;
        }

        public StoreHours(DayofWeek weekDay, StoreStatus sStatus)
        {
            this._weekDay = weekDay;
            this._sStatus = sStatus;
        }

        public DayofWeek WeekDay
        {
            get { return _weekDay; }
            set { _weekDay = value; }
        }

        public String Timings
        {
            get
            {
                if (this._sStatus == StoreStatus.Closed)
                    return StoreStatus.Closed.ToString();
                else
                {
                    DateTime startTime = DateTime.Today.Add(this._startTime);
                    DateTime endTime = DateTime.Today.Add(this._endTime);

                    return startTime.ToString("hh:mm tt") + " - " + endTime.ToString("hh:mm tt");
                }
            }
        }
    }
}