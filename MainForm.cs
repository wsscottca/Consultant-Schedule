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
    public partial class MainForm : Form
    {
        public user User;
        public MainForm(user user)
        {
            InitializeComponent();
            User = user;
            LoadData();

            using (var context = new client_scheduleEntities())
            {
                DateTime upcoming = DateTime.UtcNow.AddMinutes(15);
                DateTime now = DateTime.UtcNow;
                try
                {
                    // Lambda used to test each appointment against set conditions when grabbing it
                    // Instead of grabbing all appointments then testing the criteria against each.
                    var userAppointment = context.appointments
                                            .Single(a =>
                                                a.start >= now
                                                && a.start < upcoming
                                                && a.userId == User.userId);
                    if (userAppointment != null) MessageBox.Show(User.userName + " you have an appointment with " + userAppointment.customer.customerName + " at " + userAppointment.start.ToLocalTime().ToString("hh:mm tt"));
                }
                catch (Exception)
                { }
            }
        }

        public void LoadData()
        {
            using (var context = new client_scheduleEntities())
            {
                // Lambda used to get relevant info from each appointment and then pass that info into a new object used to display in a dataGridView
                // Saves having to get the appointments, then having to loop through each and create a new list of each individual AppointmentView
                var appointments = context.appointments
                                            .Select(a => new 
                                                {
                                                    a.appointmentId,
                                                    a.user.userName,
                                                    a.customer.customerName,
                                                    a.type,
                                                    a.title,
                                                    a.description,
                                                    a.location,
                                                    a.contact,
                                                    a.start,
                                                    a.end
                                                })
                                            .AsEnumerable()
                                            .Select(a => new AppointmentView
                                                (
                                                    a.appointmentId,
                                                    a.userName,
                                                    a.customerName,
                                                    a.type,
                                                    a.title,
                                                    a.description,
                                                    a.location,
                                                    a.contact,
                                                    a.start,
                                                    a.end
                                                ))
                                            .ToList();
                dgvAppointments.DataSource = appointments;

                var customers = context.customers
                                            .Select(c => new
                                               {
                                                    c.customerId,
                                                    c.customerName, 
                                                    Street = c.address.address1 + " " + c.address.address2,
                                                    c.address.city.city1,
                                                    c.address.city.country.country1,
                                                    c.active 
                                                })
                                            .ToList();
                dgvCustomers.DataSource = customers;
            }
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(User.userId);
            addAppointmentForm.Show();
            addAppointmentForm.FormClosing += AddAppointmentFormClosing;
        }

        private void AddAppointmentFormClosing(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnModifyAppointment_Click(object sender, EventArgs e)
        {
            int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
            ModifyAppointmentForm modifyAppointmentForm = new ModifyAppointmentForm(User.userId, appointmentId);
            modifyAppointmentForm.Show();
            modifyAppointmentForm.FormClosing += ModifyAppointmentFormClosing;
        }

        private void ModifyAppointmentFormClosing(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            using (var context = new client_scheduleEntities())
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
                context.appointments.Remove(context.appointments.Single(a => a.appointmentId == appointmentId));
                context.SaveChanges();
            }
            LoadData();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(User);
            addCustomerForm.Show();

            addCustomerForm.FormClosing += AddAppointmentFormClosing;
        }

        private void AddCustomerFormClosing(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnModifyCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            customer customer;
            using (var context = new client_scheduleEntities())
            {
                customer = context.customers.First(c => c.customerId == customerId);
                if (customer == null)
                {
                    throw new KeyNotFoundException();
                }

                ModifyCustomerForm modifyCustomerForm = new ModifyCustomerForm(User, customer);
                modifyCustomerForm.Show();
                modifyCustomerForm.FormClosing += ModifyCustomerFormClosing;
            }
        }
        private void ModifyCustomerFormClosing(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells[0].Value);
            using (var context = new client_scheduleEntities())
            {
                context.appointments.RemoveRange(context.appointments.Where(a => a.customerId == customerId));
                context.customers.Remove(context.customers.Single(c => c.customerId == customerId));
                context.SaveChanges();
            }
            LoadData();
        }

        private void BtnAllAppointments_Click(object sender, EventArgs e)
        {
            using (var context = new client_scheduleEntities())
            {
                var appointments = context.appointments
                                                .Select(a => new
                                                {
                                                    a.appointmentId,
                                                    a.user.userName,
                                                    a.customer.customerName,
                                                    a.type,
                                                    a.title,
                                                    a.description,
                                                    a.location,
                                                    a.contact,
                                                    a.start,
                                                    a.end
                                                })
                                                .AsEnumerable()
                                                .Select(a => new AppointmentView
                                                    (
                                                        a.appointmentId,
                                                        a.userName,
                                                        a.customerName,
                                                        a.type,
                                                        a.title,
                                                        a.description,
                                                        a.location,
                                                        a.contact,
                                                        a.start,
                                                        a.end
                                                    ))
                                                .ToList();
                dgvAppointments.DataSource = appointments;
                dgvAppointments.Columns[0].Width = 30;
            }
        }

        private void BtnMonthAppointments_Click(object sender, EventArgs e)
        {
            using (var context = new client_scheduleEntities())
            {
                var appointments = context.appointments
                                                .Where(a => a.start.Month == DateTime.Now.Month)
                                                .Select(a => new
                                                {
                                                    a.appointmentId,
                                                    a.user.userName,
                                                    a.customer.customerName,
                                                    a.type,
                                                    a.title,
                                                    a.description,
                                                    a.location,
                                                    a.contact,
                                                    a.start,
                                                    a.end
                                                })
                                                .AsEnumerable()
                                                .Select(a => new AppointmentView
                                                    (
                                                        a.appointmentId,
                                                        a.userName,
                                                        a.customerName,
                                                        a.type,
                                                        a.title,
                                                        a.description,
                                                        a.location,
                                                        a.contact,
                                                        a.start,
                                                        a.end
                                                    ))
                                                .ToList();
                dgvAppointments.DataSource = appointments;
                dgvAppointments.Columns[0].Width = 30;
            }
        }

        private void BtnWeekAppointments_Click(object sender, EventArgs e)
        {
            var weekOut = DateTime.Now.AddDays(7).Day;
            using (var context = new client_scheduleEntities())
            {
                var appointments = context.appointments
                                                .Where(a => a.start.Day >= DateTime.Now.Day && a.start.Day <= weekOut)
                                                .Select(a => new
                                                {
                                                    a.appointmentId,
                                                    a.user.userName,
                                                    a.customer.customerName,
                                                    a.type,
                                                    a.title,
                                                    a.description,
                                                    a.location,
                                                    a.contact,
                                                    a.start,
                                                    a.end
                                                })
                                                .AsEnumerable()
                                                .Select(a => new AppointmentView
                                                    (
                                                        a.appointmentId,
                                                        a.userName,
                                                        a.customerName,
                                                        a.type,
                                                        a.title,
                                                        a.description,
                                                        a.location,
                                                        a.contact,
                                                        a.start,
                                                        a.end
                                                    ))
                                                .ToList();
                dgvAppointments.DataSource = appointments;
                dgvAppointments.Columns[0].Width = 30;
            }
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
        }
    }
}
