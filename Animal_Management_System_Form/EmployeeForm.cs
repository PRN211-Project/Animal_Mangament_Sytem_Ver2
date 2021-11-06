using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form
{
    public partial class EmployeeForm : UserControl
    {
        public Employee CurrentEmployee;
        private IEmployeeRepository employeeRepository;

        private static EmployeeForm _instance;

        public static EmployeeForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeeForm();
                }

                return _instance;
            }
        }
        private EmployeeForm()
        {
            InitializeComponent();
            employeeRepository = new ImplEmployeeRepository();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Text = CurrentEmployee.Id.ToString();
            txtUsername.Text = CurrentEmployee.Username;
            txtPassword.Text = CurrentEmployee.Password;
            txtName.Text = CurrentEmployee.Name;
            txtPhone.Text = CurrentEmployee.Phone;
            txtAge.Text = CurrentEmployee.Age.ToString();
            txtAreaId.Text = CurrentEmployee.AreaId.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Enter All Information Please");
                return;
            }
            int age = Convert.ToInt32(txtAge.Text);
            CurrentEmployee.Username = username;
            CurrentEmployee.Password = password;
            CurrentEmployee.Name = name;
            CurrentEmployee.Phone = phone;
            CurrentEmployee.Age = age;
            employeeRepository.UpdateEmployee(CurrentEmployee);
            EmployeeForm_Load(sender,e);

        }
    }
}
