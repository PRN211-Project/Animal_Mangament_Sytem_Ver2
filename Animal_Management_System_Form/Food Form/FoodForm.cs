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
using Animal_Management_System_Form.Food_Form;

namespace Animal_Management_System_Form
{
    public partial class FoodForm : UserControl
    {
        private IFoodRepository foodRepository;
        //Singleton
        private static FoodForm _instance;
        private BindingSource source;

        public static FoodForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FoodForm();
                }

                return _instance;
            }
        }

        private FoodForm()
        {
            InitializeComponent();
            foodRepository = new ImplFoodRepository();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var index = dataGridView2.CurrentCell.RowIndex;
            int foodId = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value.ToString());
            try
            {
                if (MessageBox.Show($"Do you sure you want to delete this edible food?", "Delete food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var deletefood = foodRepository.GetFoodById(foodId);
                    foodRepository.DeleteFood(deletefood);
                    loadFood();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = foodRepository.GetAllFoods();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var foodName = txtFoodName.Text;
            DateTime expireDateTime = dateTimePicker1.Value;
            if (expireDateTime < DateTime.Now)
            {
                MessageBox.Show("Expired Date is lower than today");
                return;
            }

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("Enter Food Name please!!");
                return;
            }
            foodRepository.AddNewFood(new Food { Name = foodName, ExpiredDate = expireDateTime});
            loadFood();

        }

        private void loadFood()
        {
            var foodList = foodRepository.GetAllFoods();
            try
            {

                source = new BindingSource();
                source.DataSource = foodList;
                dataGridView2.DataSource = source;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.Columns[3].Visible = false;

               
                if (foodList.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load food");
            }
        }
        

        private void FoodForm_Load(object sender, EventArgs e)
        {
            loadFood();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var index = dataGridView2.CurrentCell.RowIndex;
            int foodId = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value.ToString());

            FoodDetails form = new FoodDetails();
            form.updatedFoodId = foodId;
            form.ShowDialog();
            loadFood();
        }
    }
}
