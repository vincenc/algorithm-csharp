/*
 * https://leetcode.com/problems/design-log-storage-system/
 * Runtime: 272 ms, faster than 91.67% of C# online submissions for Design Log Storage System.
 * Memory Usage: 33.9 MB, less than 100.00% of C# online submissions for Design Log Storage System.
 * 
 * this question's hard part is deal with the filter region when granularity changed
 * this solution created a DateRegion class to cover clearly the start time shift and end time shift logic
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithm_csharp
{
    public class LogSystem
    {
        private List<Log> m_datas;
        private string[] m_pattern = new[] { "yyyy:MM:dd:HH:mm:ss" };

        public LogSystem()
        {
            m_datas = new List<Log>();
        }
        public void Put(int id, string timestamp)
        {
            if (string.IsNullOrEmpty(timestamp)) throw new ArgumentException(" no enter timestamp");
            if (timestamp.Where(n => n == ':').Count() != 5) throw new ArgumentException(" timestamp not match pattern yyyy:MM:dd:HH:mm:ss");

            DateTime _tempTimeStamp = DateTime.ParseExact(timestamp, m_pattern, null, System.Globalization.DateTimeStyles.None);
            m_datas.Add(new Log(id, _tempTimeStamp));
        }
        public IList<int> Retrieve(string s, string e, string gra)
        {
            IList<int> _result = new List<int>();
            DatetimeRegion _dateRegion = new DatetimeRegion(s, e, gra, m_pattern);
            _result = searchByDateTimeRange(_dateRegion);
            return _result;
        }        
        private List<int> searchByDateTimeRange(DatetimeRegion dateTimeRegion)
        {
            return m_datas.Where(n => n.TimeStamp >= dateTimeRegion.Start && n.TimeStamp <= dateTimeRegion.End).Select(n => n.Id).ToList();
        }
    }

    public class Log
    {
        private int m_id;
        public int Id
        {
            get { return m_id; }
        }
        public DateTime TimeStamp { get; set; }
        public Log(int id, DateTime dateTime)
        {
            m_id = id;
            TimeStamp = dateTime;
        }
    }

    public class DatetimeRegion
    {
        private string[] m_pattern = new[] { "yyyy:MM:dd:HH:mm:ss" };
        private DateTime m_end;
        private DateTime m_start;
        public DateTime Start
        {
            get { return m_start; }
        }
        public DateTime End
        {
            get { return m_end; }
        }
        private string Granularity { get; set; }
        public DatetimeRegion(string start, string end, string gra, string[] pattern)// pattern yyyy:MM:dd:HH:mm:ss
        {
            m_pattern = pattern;
            Granularity = gra;
            m_end = DateTime.ParseExact(end, m_pattern, null, System.Globalization.DateTimeStyles.None);
            m_end = modifyEndTimeToIncludeGraRange(m_end);

            m_start = DateTime.ParseExact(start, m_pattern, null, System.Globalization.DateTimeStyles.None);
            m_start = modifyStartTimeToIncludeGraRange(m_start);

        }
        private DateTime modifyStartTimeToIncludeGraRange(DateTime start)
        {
            switch (Granularity.ToLower())
            {
                case "year":
                    start = new DateTime(start.Year, 1, 1);
                    break;
                case "month":
                    start = new DateTime(start.Year, start.Month, 1);
                    break;
                case "day":
                    start = new DateTime(start.Year, start.Month, start.Day);
                    break;
                case "hour":
                    start = new DateTime(start.Year, start.Month, start.Day, start.Hour, 0, 0);
                    break;
                case "minute":
                    start = new DateTime(start.Year, start.Month, start.Day, start.Hour, start.Minute, 0);
                    break;
            }
            return start;
        }

        private DateTime modifyEndTimeToIncludeGraRange(DateTime end)
        {
            switch (Granularity.ToLower())
            {
                case "year":
                    end = new DateTime(end.Year + 1, 1, 1).AddSeconds(-1);
                    break;
                case "month":
                    if (end.Month == 12)
                        end = new DateTime(end.Year + 1, 1, 1).AddSeconds(-1);
                    else
                    {
                        end = new DateTime(end.Year, end.Month + 1, 1).AddSeconds(-1);
                    }
                    break;
                case "day":
                    end = new DateTime(end.Year, end.Month, end.Day).AddDays(1).AddSeconds(-1);
                    break;
                case "hour":
                    end = new DateTime(end.Year, end.Month, end.Day, end.Hour, 59, 59);
                    break;
                case "minute":
                    end = new DateTime(end.Year, end.Month, end.Day, end.Hour, end.Minute, 59);
                    break;
            }
            return end;
        }        
    }

    /**
     * Your LogSystem object will be instantiated and called as such:
     * LogSystem obj = new LogSystem();
     * obj.Put(id,timestamp);
     * IList<int> param_2 = obj.Retrieve(s,e,gra);
     */
}
