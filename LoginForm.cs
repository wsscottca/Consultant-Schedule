using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class LoginForm : Form
    {
        private static readonly string PATH = Application.StartupPath + "\\log.txt";
        public LoginForm()
        {
            Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            InitializeComponent();
            InitializeLanguage();
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public bool Authenticated { get; set; } = false;
        public user User { get; set; }
        public string Language { get; set; }

        private void InitializeLanguage()
        {
            if (Language == "it")
            {
                lblTitle.Text = "Titolo";
                lblPassword.Text = "Parola d'ordine";
                lblUsername.Text = "Nome utente";
                Text = "Modulo di accesso";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" )
            {
                if (Language == "it")
                {
                    MessageBox.Show("Si prega di inserire un nome utente e una password.", "Inserimento non valido");
                }
                else
                {
                    MessageBox.Show("Please enter a username and password.", "Invalid Input");
                }
                
                return;
            }
            using (var context = new client_scheduleEntities())
            using (var stream = new StreamWriter(PATH, true))
            {
                var user = context.users.First(u => u.userName == txtUsername.Text);
                if(user == null)
                {
                    if (Language == "it")
                    {
                        MessageBox.Show("Utente '" + txtUsername.Text + "' non trovato.", "Utente non trovato");
                    }
                    else
                    {
                        MessageBox.Show("User '" + txtUsername.Text + "' does not exist.", "User Not Found");
                    }
                    return;
                }

                if (user.password == txtPassword.Text)
                {
                    User = user;
                    Authenticated = true;
                    stream.WriteLine("User '" + user.userName + "' logged in at UTC " + DateTime.UtcNow.ToString("G"));
                    Close();
                }
                else
                {
                    stream.WriteLine("User '" + user.userName + "' failed to login at UTC " + DateTime.UtcNow.ToString("G"));
                    if (txtPassword.Text == "")
                    {
                        if (Language == "it")
                        {
                            MessageBox.Show("Per favore inserire una password.", "Inserimento non valido");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a password.", "Invalid Input");
                        }
                        return;
                    }

                    if (Language == "it")
                    {
                        MessageBox.Show("Nome utente / password non valido.", "Errore di accesso");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password.", "Login Error");
                    }
                }
            }
        }
    }
}
