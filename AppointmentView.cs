using System;

namespace Scheduling_App
{
    internal class AppointmentView
    {
        public int AppointmentId { get; set; }
        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public AppointmentView() { }

        public AppointmentView(int appointmentId, string userName, string customerName, string type, string title, string description, string location, string contact, DateTime start, DateTime end)
        {
            AppointmentId = appointmentId;
            UserName = userName;
            CustomerName = customerName;
            Type = type;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Start = start.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt");
            End = end.ToLocalTime().ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}