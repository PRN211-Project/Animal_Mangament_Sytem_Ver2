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

            dataGridView1.DataSource = employeeRepository.GetAllEmployees();
        }
    }
}
