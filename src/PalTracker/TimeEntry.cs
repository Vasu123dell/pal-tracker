using System;
using System.Collections.Generic;

namespace PalTracker
{
    public class TimeEntry
    {
        public long? Param1 { get; set; }
        public long Param2 { get; set; }
        public long Param3 { get; set; }
        public DateTime Date { get; set; }
        public long Param4 { get; set; }

        public TimeEntry()
        {

        }
        public TimeEntry(long param1, long param2,  DateTime date, long param3)
        {
            Param1 = param1;
            Param2 = param2;
            Date = date;
            Param3 = param3;
        }
        public TimeEntry(long param1, long param2,  long param3, DateTime date, long param4)
        {
            Param1 = param1;
            Param2 = param2;
            Param3 = param3;
            Date = date;
            Param4 = param4;
        }

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   EqualityComparer<long?>.Default.Equals(Param1, entry.Param1) &&
                   Param2 == entry.Param2 &&
                   Param3 == entry.Param3 &&
                   Date == entry.Date &&
                   Param4 == entry.Param4;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Param1, Param2, Param3, Date, Param4);
        }
    }
}