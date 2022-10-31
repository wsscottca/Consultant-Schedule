using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class AddCustomerForm : Form
    {
        private readonly user User;
        public AddCustomerForm(user user)
        {
            InitializeComponent();
            User = user;
        }

        private address AddressExists(client_scheduleEntities context)
        {
            try
            {
                var country = ExistingCountry(context);
                var city = ExistingCity(context, country);
                var address = ExistingAddress(context, city);
                return address;
            }
            catch (KeyNotFoundException)
            {
                throw;
            }
        }

        private address ExistingAddress(client_scheduleEntities context, city city)
        {
            var exists = city.addresses
                                    .Any(a =>
                                        a.address1 == txtAddress1.Text
                                        && a.address2 == txtAddress2.Text
                                        && a.postalCode == txtPostalCode.Text);

            if (exists)
            {
                return city.addresses
                                    .First(a =>
                                        a.address1 == txtAddress1.Text
                                        && a.address2 == txtAddress2.Text
                                        && a.postalCode == txtPostalCode.Text);
            }
            else
            {
                throw new KeyNotFoundException("Address " + txtAddress1.Text + " " + txtAddress2.Text +
                                                " with postal code " + txtPostalCode.Text +
                                                " does not exist in city " + txtCity.Text + " in DB.");
            }
        }

        private city ExistingCity(client_scheduleEntities context, country country)
        {
            var exists = country.cities.Any(c => c.city1 == txtCity.Text);

            if (exists)
            {
                return country.cities.First(c => c.city1 == txtCity.Text);
            }
            else
            {
                throw new KeyNotFoundException("City " + txtCity.Text + " does not exist in country " + txtCountry.Text + " in DB.");
            }
        }

        private country ExistingCountry(client_scheduleEntities context)
        {
            var exists = context.countries.Any(c => c.country1 == txtCountry.Text);

            if (exists)
            {
                return context.countries.First(c => c.country1 == txtCountry.Text);
            }
            else
            {
                throw new KeyNotFoundException("Country " + txtCountry.Text + " does not exist in DB.");
            }
        }

        private void AddCountry(client_scheduleEntities context, country country)
        {
            context.countries.Add(country);
            context.SaveChanges();
        }

        private void AddCity(client_scheduleEntities context, city city)
        {
            context.cities.Add(city);
            context.SaveChanges();
        }

        private void AddAddress(client_scheduleEntities context, address address)
        {
            context.addresses.Add(address);
            context.SaveChanges();
        }

        private void AddCustomer(client_scheduleEntities context, customer customer)
        {
            context.customers.Add(customer);
            context.SaveChanges();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "" || txtPhone.Text == "" || txtAddress1.Text == ""
                    || txtPostalCode.Text == "" || txtCity.Text == "" || txtCountry.Text == "")
            {
                MessageBox.Show("Please fill all required inputs.", "Missing Input");
                return;
            } 
            else
            {
                txtName.Text = txtName.Text.Trim();
                txtPhone.Text = txtPhone.Text.Trim();
                txtAddress1.Text = txtAddress1.Text.Trim();
                if(txtAddress2.Text != "") txtAddress2.Text = txtAddress2.Text.Trim();
                txtPostalCode.Text = txtPostalCode.Text.Trim();
                txtCity.Text = txtCity.Text.Trim();
                txtCountry.Text = txtCountry.Text.Trim();
            }
            address address;
            int id;
            DialogResult dialogResult;
            using (var context = new client_scheduleEntities())
            {
                try
                {
                    address = AddressExists(context);
                    id = context.customers.Max(c => c.customerId) + 1;
                    AddCustomer(context, new customer(id, txtName.Text, address.addressId, true, DateTime.UtcNow, User.userName, DateTime.UtcNow, User.userName, address));
                    Close();
                }
                catch (KeyNotFoundException ex)
                {
                    dialogResult = MessageBox.Show(ex.Message + "\nWould you like to add it?", "Address Not Found", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        country country;
                        city city;
                        if (ex.Message.StartsWith("Country"))
                        {
                            id = context.countries.Max(c => c.countryId) + 1;
                            AddCountry(context, new country(id, txtCountry.Text, DateTime.UtcNow, User.userName, DateTime.UtcNow, User.userName));
                        }
                        else if (ex.Message.StartsWith("City"))
                        {
                            country = context.countries.First(c => c.country1 == txtCountry.Text);
                            id = context.cities.Max(c => c.cityId) + 1;
                            AddCity(context, new city(id, txtCity.Text, country.countryId, DateTime.UtcNow, User.userName, DateTime.UtcNow, User.userName, country));
                        }
                        else if (ex.Message.StartsWith("Address"))
                        {
                            country = context.countries.First(c => c.country1 == txtCountry.Text);
                            city = context.cities
                                                .First(c =>
                                                    c.city1 == txtCity.Text
                                                    && c.countryId == country.countryId);
                            id = context.addresses.Max(a => a.addressId) + 1;
                            AddAddress(context, new address(id, txtAddress1.Text, txtAddress2.Text, city.cityId, txtPostalCode.Text,
                                                                txtPhone.Text, DateTime.UtcNow, User.userName, DateTime.UtcNow, User.userName, city));
                        }
                        id = context.customers.Max(c => c.customerId) + 1;
                        country = context.countries.First(c => c.country1 == txtCountry.Text);
                        city = context.cities.First(c => c.city1 == txtCity.Text);
                        address = context.addresses
                                                    .First(a =>
                                                            a.address1 == txtAddress1.Text
                                                            && a.address2 == txtAddress2.Text
                                                            && a.cityId == city.cityId);
                        AddCustomer(context, new customer(id, txtName.Text, address.addressId, true, DateTime.UtcNow, User.userName, DateTime.UtcNow, User.userName, address));
                        Close();
                    }
                }
            }
        }
    }
}
