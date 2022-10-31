using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            int month;
            switch (txtMonth.Text.Trim().ToLower())
            {
                case "january":
                    month = 1;
                    break;
                case "feburary":
                    month = 2;
                    break;
                case "march":
                    month = 3;
                    break;
                case "april":
                    month = 4;
                    break;
                case "may":
                    month = 5;
                    break;
                case "june":
                    month = 6;
                    break;
                case "july":
                    month = 7;
                    break;
                case "august":
                    month = 8;
                    break;
                case "september":
                    month = 9;
                    break;
                case "october":
                    month = 10;
                    break;
                case "november":
                    month = 11;
                    break;
                case "december":
                    month = 12;
                    break;

                default:
                    MessageBox.Show("Please enter a valid month.", "Invalid Input");
                    return;
            }
            using (var context = new client_scheduleEntities())
            {
                int year = DateTime.UtcNow.Year;
                try
                {
                    var results = context.appointments.Where(a => a.type == txtType.Text
                                                            && a.start.Year == year
                                                            && a.start.Month == month);
                    lblCount.Text = "Count: " + results.Count();
                    return;
                }
                catch
                {
                    lblCount.Text = "Count: 0";
                    return;
                }
            }
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            using (var context = new client_scheduleEntities())
            {
                int userId;
                try
                {
                    userId = context.users.First(u => u.userName == txtUser.Text).userId;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("User '" + txtUser.Text + "' does not exist.", "No Data");
                    return;
                }
                
                try
                {
                    var appointments = context.appointments
                                                .Where(a => a.userId == userId)
                                                .Select(a => new
                                                {
                                                    a.appointmentId,
                                                    a.user.userName,
                                                    a.customer.customerName,
                                                    a.type,
                                                    a.start,
                                                })
                                                .AsEnumerable()
                                                .Select(a => new AppointmentSimpleView
                                                    (
                                                        a.appointmentId,
                                                        a.userName,
                                                        a.customerName,
                                                        a.type,
                                                        a.start
                                                    ))
                                                .ToList();
                    dgvAppointments.DataSource = appointments;
                    dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("User '" + txtUser.Text + "' does not have any appointments.", "No Data");
                    return;
                }
                
            }
        }

        private void BtnCountDay_Click(object sender, EventArgs e)
        {
            using (var context = new client_scheduleEntities())
            {
                try
                {
                    var count = context.appointments.Count();
                    lblCountAppts.Text = "Count: " + count;
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("No appointments in schedule.", "No Data");
                    return;
                }
            }
        }
    }
}
