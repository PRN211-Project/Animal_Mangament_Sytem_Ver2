using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_Management_System_Form.Animal_Form
{
    public partial class AnimalDetails : Form
    {
        public IAnimalRepository animalRepository { get; set; }
        public Animal AnimalInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public Employee CurrentEmployee;
        IAreaRepository areaRepository = new ImplAreaRepository();
        public ITypeRepository typeRepository = new ImplTypeRepository();

        public AnimalDetails()
        {
            InitializeComponent();
            cboArea.ValueMember = "AreaId";
            DTImportedDate.Value = DateTime.Now;
            var typeList = typeRepository.GetAllTypes();
            cboType.ValueMember = "Id";
            cboType.DataSource = typeList;
        }

        private void AnimalDetails_Load(object sender, EventArgs e)
        {
            if (CurrentEmployee == null)
            {
                var areaList = areaRepository.GetAllAreas();
                cboArea.DataSource = areaList;
            }
            else
            {
                cboArea.Items.Add(CurrentEmployee.AreaId);
            }
            txtAnimalID.Enabled = false;

            if (InsertOrUpdate == true)
            {
                txtAnimalID.Text = AnimalInfo.Id.ToString();
                txtName.Text = AnimalInfo.Name.ToString();
                txtAge.Text = AnimalInfo.Age.ToString();
                txtWeight.Text = AnimalInfo.Weight.ToString();
                DTImportedDate.Text = AnimalInfo.ImportedDateTime.ToString();
                cboArea.Text = AnimalInfo.AreaId.ToString();
                cboType.Text = AnimalInfo.TypeId.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool Valid = true;
            System.Text.RegularExpressions.Regex num = new System.Text.RegularExpressions.Regex("^[0-9]{1,3}");
            txtAnimalID.Enabled = false;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Valid = false;
                if (MessageBox.Show("Name is empty", "SAVE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }

            }

            if (string.IsNullOrEmpty(txtAge.Text) || !num.IsMatch(txtAge.Text.Trim()))
            {
                Valid = false;
                if (MessageBox.Show("Age is incorrect format", "SAVE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }

            }
            if (string.IsNullOrEmpty(txtWeight.Text) || !num.IsMatch(txtWeight.Text.Trim()))
            {
                Valid = false;
                if (MessageBox.Show("Weight is empty", "SAVE", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }

            }




            if (InsertOrUpdate == false && Valid == true)
            {
                var animal = new Animal
                {

                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Weight = double.Parse(txtWeight.Text),
                    ImportedDateTime = DateTime.Parse(DTImportedDate.Text),
                    AreaId = int.Parse(cboArea.Text),
                    TypeId = int.Parse(cboType.Text)
                };
                animalRepository.AddNewAnimal(animal);
                MessageBox.Show("Add animal Successfully!!", "ADD ANIMAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            if (InsertOrUpdate == true && Valid == true)
            {
                var animal = new Animal
                {
                    Id = int.Parse(txtAnimalID.Text),
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Weight = double.Parse(txtWeight.Text),
                    ImportedDateTime = DateTime.Parse(DTImportedDate.Text),
                    AreaId = int.Parse(cboArea.Text),
                    TypeId = int.Parse(cboType.Text)
                };
                animalRepository.UpdateAnimal(animal);
                MessageBox.Show("Update animal Successfully!!", "UPDATE ANIMAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


    }





}
