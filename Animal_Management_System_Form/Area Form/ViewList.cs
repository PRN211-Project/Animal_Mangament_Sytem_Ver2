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

namespace Animal_Management_System_Form.AreaForm
{
    public partial class ViewList : Form
    {

        private IEmployeeRepository employeeRepository;
        private IAnimalRepository animalRepository;
        public bool isViewAnimal;
        public int areaID;
        public ViewList()
        {
            InitializeComponent();
            employeeRepository = new ImplEmployeeRepository();
            animalRepository = new ImplAnimalRepository();
        }

        private void ViewList_Load(object sender, EventArgs e)
        {
            if (isViewAnimal)
            {
                var animalList = animalRepository.GetAllAnimalsByAreaId(areaID);
                dataGridView1.DataSource = animalList;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
            }
            else
            {
                Title.Text = "List Employee";
                var employeeList = employeeRepository.GetAllEmployeesByAreaId(areaID);
                dataGridView1.DataSource = employeeList;
                dataGridView1.Columns[7].Visible = false;
            }
        }
    }
}
