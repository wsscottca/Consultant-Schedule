using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class AddAppointmentForm : Form
    {
        private List<AppointmentTimesView> potentialTimes = new List<AppointmentTimesView>();
        private readonly int UserId;
        public AddAppointmentForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
            calendar.MinDate = DateTime.Now;
        }

        private void BtnFindTimes_Click(object sender, EventArgs e)
        {
            if (txtConsultant.Text == "")
            {
                MessageBox.Show("Please enter a consultant name." , "Invalid Input");
            }
            using(var context = new client_scheduleEntities())
            {
                int userId;
                try
                {
                    userId = FindUser(txtConsultant.Text);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Consultant '" + txtConsultant.Text + "' does not exist.", "Consultant Not Found");
                    return;
                }

                DateTime date = calendar.SelectionStart.Date;
                var appointments = context.appointments
                                                    .Where(a => a.userId == userId 
                                                        && a.start.Year == date.Year
                                                        && a.start.Month == date.Month
                                                        && a.start.Day == date.Day)
                                                    .AsEnumerable()
                                                    .Select(a => new AppointmentTimesView(a.start, a.end))
                                                    .ToList();

                List<string> openTimes = GetAvailableTimes(appointments);
                var openTimesView = openTimes.Select(o => new { Times=o }).ToList();
                dgvAvailableTimes.DataSource = openTimesView;
            }
        }

        private List<string> GetAvailableTimes(List<AppointmentTimesView> appointments)
        {
            DateTime day = calendar.SelectionStart.Date;
            DateTime dayStart = day.AddHours(8.0);
            DateTime dayEnd = day.AddHours(17.0);

            DateTime appointmentTime = dayStart;

            potentialTimes.Clear();
            while (appointmentTime < dayEnd)
            {
                int appointmentDuration;
                if (radioThirty.Checked)
                {
                    appointmentDuration = 30;
                }
                else if (radioSixty.Checked)
                {
                    appointmentDuration = 60;
                }
                else
                {
                    appointmentDuration = 90;
                }

                if (appointmentTime.AddMinutes(appointmentDuration) > dayEnd) break;
                potentialTimes.Add(new AppointmentTimesView(appointmentTime.ToUniversalTime(), appointmentTime.AddMinutes(appointmentDuration).ToUniversalTime()));
                appointmentTime = appointmentTime.AddMinutes(15);
            }
            List<string> openTimes = new List<string>();
            foreach (var potentialAppointment in potentialTimes)
            {
                openTimes.Add(potentialAppointment.Start.ToString("t"));
            }

            foreach (var appointment in appointments)
            {
                foreach (var potentialAppointment in potentialTimes)
                {
                    if ((potentialAppointment.Start >= appointment.Start
                        && potentialAppointment.Start <= appointment.End)
                        ||
                        (potentialAppointment.End >= appointment.Start
                        && potentialAppointment.End <= appointment.End)
                        ||
                        (potentialAppointment.Start <= appointment.Start
                        && potentialAppointment.End >= appointment.Start))
                    {
                        openTimes.Remove(potentialAppointment.Start.ToString("t"));
                    }
                }
            }

            return openTimes;
        }

        private int FindUser(string name)
        {
            using (var context = new client_scheduleEntities())
            {
                return context.users.First(u => u.userName == name).userId;
            }

        }
        private int FindCustomer(string name)
        {
            using (var context = new client_scheduleEntities())
            {
                return context.customers.First(c => c.customerName == name).customerId;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConsultant.Text == ""
                    || txtCustomer.Text == ""
                    || txtType.Text == ""
                    || dgvAvailableTimes.SelectedRows[0] == null)
                {
                    MessageBox.Show("Consultant, Customer, Type, and Time are required.", "Missing Input");
                    return;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a time.", "Missing Input");
                return;
            }

            using (var context = new client_scheduleEntities())
            {
                int userId;
                try
                {
                    userId = FindUser(txtConsultant.Text);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Consultant '" + txtConsultant.Text + "' does not exist.", "Consultant Not Found");
                    return;
                }
                int customerId;
                try
                {
                    customerId = FindCustomer(txtCustomer.Text);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Customer '" + txtCustomer.Text + "' does not exist." + "\n\n If this is a new customer, please add them to the system.", "Consultant Not Found");
                    return;
                }
                AppointmentTimesView appointmentTime = potentialTimes.Single(t => t.Start.ToString("t") == (string)dgvAvailableTimes.SelectedRows[0].Cells[0].Value);
                int appointmentId = context.appointments.Max(a => a.appointmentId);
                string userName = context.users.Single(u => u.userId == UserId).userName;
                customer customer = context.customers.Single(c => c.customerId == customerId);
                user user = context.users.Single(u => u.userId == userId);
                context.appointments.Add(new appointment(appointmentId, customerId, userId, txtAptTitle.Text, txtDescription.Text, txtLocation.Text,
                                                            txtContact.Text, txtType.Text, txtUrl.Text, appointmentTime.Start.ToUniversalTime(), 
                                                            appointmentTime.End.ToUniversalTime(), DateTime.UtcNow, userName, DateTime.UtcNow, userName, customer, user));
                context.SaveChanges();
                Close();
            }
        }

        
    }
}
