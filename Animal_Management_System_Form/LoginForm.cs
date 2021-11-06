using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;
using Newtonsoft.Json;

namespace Animal_Management_System_Form
{
    public partial class LoginForm : Form
    {
        private IEmployeeRepository employeeRepository;
        private Manager manager;
        public LoginForm()
        {
            InitializeComponent();
            employeeRepository = new ImplEmployeeRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter username and password please!!");
                return;
            }
            else
            {
                if (manager.username.Equals(username) && manager.password.Equals(password))
                {
                    Home menu = new Home();
                    menu.Closed += (sender, e) => this.Close();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    var employee = employeeRepository.CheckLogin(username, password);
                    if (employee != null)
                    {
                        Home menu = new Home();
                        menu.Closed += (sender, e) => this.Close();
                        this.Hide();
                        menu.CurrentEmployee = employee;
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username and Password!!");
                        return;
                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using StreamReader streamReader = new StreamReader(Path.GetFullPath("appsettings.json"));
            string json = streamReader.ReadToEnd();
            manager = JsonConvert.DeserializeObject<Manager>(json);
        }
    }
}
