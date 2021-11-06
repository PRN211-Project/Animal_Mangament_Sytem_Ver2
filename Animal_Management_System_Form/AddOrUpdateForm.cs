using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form
{
    public partial class AddOrUpdateForm : Form
    {
        public bool isAdd = true;
        public int updateEmployeeId;
        private Employee updateEmployee;
        private IEmployeeRepository employeeRepository;
        private IAreaRepository areaRepository;
        public AddOrUpdateForm()
        {
            InitializeComponent();
            employeeRepository = new ImplEmployeeRepository();
            areaRepository = new ImplAreaRepository();
        }

        private void AddOrUpdateForm_Load(object sender, EventArgs e)
        {
            var areaList = areaRepository.GetAllAreas();
            foreach (var area in areaList)
            {
                cbArea.Items.Add(area.AreaId);
            }
            if (isAdd)
            {
                idLabel.Visible = false;
                txtEmployeeId.Visible = false;
                Title.Text = "Add New Employee";
            }
            else
            {
                Title.Text = "Update Employee";
                updateEmployee = employeeRepository.GetEmployeeById(updateEmployeeId);
                txtEmployeeId.Text = updateEmployee.Id.ToString();
                txtEmployeeId.Enabled = false;
                txtUsername.Text = updateEmployee.Username;
                txtName.Text = updateEmployee.Name;
                txtPassword.Text = updateEmployee.Password;
                txtPhone.Text = updateEmployee.Phone;
                txtAge.Text = updateEmployee.Age.ToString();
                btnAddOrUpdate.Text = "Update";
                cbArea.SelectedItem = updateEmployee.AreaId;
            }
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {

                //int employeeId = Convert.ToInt32(txtEmployeeId.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name)
                    || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Enter All Information");
                    return;
                }
                int age = Convert.ToInt32(txtAge.Text);
                int selectedAreaId = Convert.ToInt32(cbArea.Text);
                Employee newEmployee = new Employee
                    { Username = username, Password = password, Name = name, Phone = phone ,Age = age, AreaId = selectedAreaId};
                employeeRepository.AddNewEmployee(newEmployee);
                this.Close();
            }
            else
            {
                int employeeId = Convert.ToInt32(txtEmployeeId.Text);
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name)
                    || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Enter All Information");
                    return;
                }
                int age = Convert.ToInt32(txtAge.Text);
                
                int selectedAreaId = Convert.ToInt32(cbArea.Text);
                Employee updatEmployee = new Employee
                    { Id = employeeId, Username = username, Password = password, Name = name, Phone = phone,Age = age, AreaId = selectedAreaId};
                employeeRepository.UpdateEmployee(updatEmployee);
                this.Close();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
