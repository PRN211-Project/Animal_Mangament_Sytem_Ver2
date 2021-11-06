using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using Animal_Management_System.Repository.Implementation;
using Animal_Management_System_Form.Animal_Form;

namespace Animal_Management_System_Form
{
    public partial class AnimalForm : UserControl
    {
        public Employee CurrentEmployee = null;
        private IAnimalRepository animalRepository;
        BindingSource source;
        //Singleton
        private static AnimalForm _instance;
        private AnimalForm()
        {
            InitializeComponent();
            animalRepository = new ImplAnimalRepository();
        }
        public static AnimalForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimalForm();
                }

                return _instance;
            }
        }
        private void ClearText()
        {
            txtAnimalID.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtImportedDate.Text = string.Empty;
            txtName.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtType.Text = string.Empty;
            txtWeight.Text = string.Empty;


        }

        private void LoadAnimal()
        {
            if (CurrentEmployee == null)
            {
                var animalList = animalRepository.GetAllAnimals();
                try
                {

                    source = new BindingSource();
                    source.DataSource = animalList;

                    txtAnimalID.DataBindings.Clear();
                    txtAge.DataBindings.Clear();
                    txtName.DataBindings.Clear();
                    txtWeight.DataBindings.Clear();
                    txtArea.DataBindings.Clear();
                    txtImportedDate.DataBindings.Clear();
                    txtType.DataBindings.Clear();

                    txtAnimalID.DataBindings.Add("Text", source, "Id");
                    txtName.DataBindings.Add("Text", source, "Name");
                    txtWeight.DataBindings.Add("Text", source, "Weight");
                    txtAge.DataBindings.Add("Text", source, "Age");
                    txtImportedDate.DataBindings.Add("Text", source, "ImportedDateTime");
                    txtType.DataBindings.Add("Text", source, "TypeId");
                    txtArea.DataBindings.Add("Text", source, "AreaId");

                    dgvAnimalManagement.DataSource = null;
                    dgvAnimalManagement.DataSource = source;
                    dgvAnimalManagement.Columns[7].Visible = false;
                    dgvAnimalManagement.Columns[8].Visible = false;
                    dgvAnimalManagement.Columns[9].Visible = false;
                    dgvAnimalManagement.AllowUserToAddRows = false;



                    if (animalList.Count() == 0)
                    {
                        ClearText();

                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load animal");
                }
            }
            else
            {
                int areaId = CurrentEmployee.AreaId.Value;
                var animalList = animalRepository.GetAllAnimalsByAreaId(areaId);
                source = new BindingSource();
                source.DataSource = animalList;

                txtAnimalID.DataBindings.Clear();
                txtAge.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtArea.DataBindings.Clear();
                txtImportedDate.DataBindings.Clear();
                txtType.DataBindings.Clear();

                txtAnimalID.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtAge.DataBindings.Add("Text", source, "Age");
                txtImportedDate.DataBindings.Add("Text", source, "ImportedDateTime");
                txtType.DataBindings.Add("Text", source, "TypeId");
                txtArea.DataBindings.Add("Text", source, "AreaId");
                txtArea.Enabled = false;
                dgvAnimalManagement.DataSource = null;
                dgvAnimalManagement.DataSource = source;
                dgvAnimalManagement.Columns[7].Visible = false;
                dgvAnimalManagement.Columns[8].Visible = false;
                dgvAnimalManagement.Columns[9].Visible = false;
                dgvAnimalManagement.AllowUserToAddRows = false;
                if (animalList.Count() == 0)
                {
                    ClearText();

                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
        }

        private void DgvAnimal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AnimalDetails frm;
            if (CurrentEmployee == null)
            {
                frm = new AnimalDetails
                {
                    Text = "UPDATE ANIMAL",
                    InsertOrUpdate = true,
                    AnimalInfo = GetAnimal(),
                    animalRepository = animalRepository
                };
            }
            else
            {
                frm = new AnimalDetails
                {
                    Text = "UPDATE ANIMAL",
                    InsertOrUpdate = true,
                    AnimalInfo = GetAnimal(),
                    animalRepository = animalRepository,
                    CurrentEmployee = this.CurrentEmployee
                };
            }
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadAnimal();
                source.Position = source.Count - 1;

            }
        }
        private Animal GetAnimal()
        {
            Animal animal = null;
            try
            {
                animal = new Animal
                {
                    Id = int.Parse(txtAnimalID.Text),
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Weight = double.Parse(txtWeight.Text),
                    ImportedDateTime = DateTime.Parse(txtImportedDate.Text),
                    AreaId = int.Parse(txtArea.Text),
                    TypeId = int.Parse(txtType.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Animal");
            }
            return animal;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show($"Do you really want to delete this Animal", "Delete animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var pro = GetAnimal();
                    animalRepository.DeleteAnimal(pro);
                    LoadAnimal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a animal");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AnimalDetails detail;
            if (CurrentEmployee != null)
            {
                detail = new AnimalDetails
                {
                    Text = "ADD ANIMAL",
                    InsertOrUpdate = false,
                    animalRepository = animalRepository,
                    CurrentEmployee = this.CurrentEmployee
                };
            }
            else
            {
                detail = new AnimalDetails
                {
                    Text = "ADD ANIMAL",
                    InsertOrUpdate = false,
                    animalRepository = animalRepository,
                };
            }
            if (detail.ShowDialog() == DialogResult.OK)
            {
                var animallist = animalRepository.GetAllAnimals();

                LoadAnimal();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearchName.Text))
                {
                    throw new Exception("Name is not correct format");

                }
                else
                {
                    var name = txtSearchName.Text;
                    IEnumerable<Animal> result = animalRepository.GetAnimalByName(name);
                    if (result.Any())
                    {
                        LoadBySearchValue(result);
                    }
                    else
                    {
                        throw new Exception("Animal not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {
            LoadAnimal();
            dgvAnimalManagement.CellDoubleClick += DgvAnimal_CellDoubleClick;
        }
        private void LoadBySearchValue(IEnumerable<Animal> searchValue)
        {

            var productList = animalRepository.GetAllAnimals();
            try
            {
                source = new BindingSource();
                source.DataSource = searchValue;

                txtAnimalID.DataBindings.Clear();
                txtAge.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtArea.DataBindings.Clear();
                txtImportedDate.DataBindings.Clear();
                txtType.DataBindings.Clear();

                txtAnimalID.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtAge.DataBindings.Add("Text", source, "Age");
                txtImportedDate.DataBindings.Add("Text", source, "ImportedDateTime");
                txtType.DataBindings.Add("Text", source, "TypeId");
                txtArea.DataBindings.Add("Text", source, "AreaId");

                dgvAnimalManagement.DataSource = null;
                dgvAnimalManagement.DataSource = source;
                dgvAnimalManagement.Columns[7].Visible = false;
                dgvAnimalManagement.Columns[8].Visible = false;
                dgvAnimalManagement.Columns[9].Visible = false;

                if (productList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product List");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAnimal();
        }
    }
}
