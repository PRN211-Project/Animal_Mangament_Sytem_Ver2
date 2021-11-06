using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form
{
    public partial class ProfileForm : UserControl
    {
        private IEmployeeRepository employeeRepository;



        //Singleton
        private static ProfileForm _instance;

        
        public static ProfileForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProfileForm();
                }

                return _instance;
            }
        }
        private ProfileForm()
        {
            InitializeComponent();
            employeeRepository = new ImplEmployeeRepository();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            EmployeeDataGridView.DataSource = employeeRepository.GetAllEmployees();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchEmployeeIdTxt = txtSearchIdEmployee.Text;
            if (string.IsNullOrWhiteSpace(searchEmployeeIdTxt))
            {
                MessageBox.Show("Enter Employee Id please!!");
                return;
            }

            int searchEmployeeId = Convert.ToInt32(searchEmployeeIdTxt);
            var member = employeeRepository.GetEmployeeById(searchEmployeeId);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = member;
            EmployeeDataGridView.DataSource = bindingSource;
            EmployeeDataGridView.AllowUserToAddRows = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            EmployeeDataGridView.DataSource = employeeRepository.GetAllEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var index = EmployeeDataGridView.CurrentCell.RowIndex;
            int employeeId =Convert.ToInt32(EmployeeDataGridView.Rows[index].Cells[0].Value.ToString());
            AddOrUpdateForm form = new AddOrUpdateForm();
            form.updateEmployeeId = employeeId;
            form.isAdd = false;
            form.ShowDialog();
            ProfileForm_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = EmployeeDataGridView.CurrentCell.RowIndex;
            int employeeId = Convert.ToInt32(EmployeeDataGridView.Rows[index].Cells[0].Value.ToString());
            var employee = employeeRepository.GetEmployeeById(employeeId);
            employeeRepository.DeleteEmployee(employee);
            ProfileForm_Load(sender,e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrUpdateForm form = new AddOrUpdateForm();
            form.isAdd = true;
            form.ShowDialog();
            ProfileForm_Load(sender, e);
        }
    }
}
