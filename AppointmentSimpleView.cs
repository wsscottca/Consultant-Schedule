using System;

namespace Scheduling_App
{
    internal class AppointmentSimpleView
    {
        public int AppointmentId { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }
        public string Start { get; set; }

        public AppointmentSimpleView() { }

        public AppointmentSimpleView(int appointmentId, string userName, string customerName, string type, DateTime start)
        {
            AppointmentId = appointmentId;
            UserName = userName;
            CustomerName = customerName;
            Type = type;
            Start = start.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}