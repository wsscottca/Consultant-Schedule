using System;

namespace Scheduling_App
{
    internal class AppointmentTimesView
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public AppointmentTimesView(DateTime start, DateTime end)
        {
            this.Start = start.ToLocalTime();
            this.End = end.ToLocalTime();
        }
    }
}