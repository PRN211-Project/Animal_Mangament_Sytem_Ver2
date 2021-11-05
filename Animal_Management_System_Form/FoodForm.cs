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
            try
            {
                if (MessageBox.Show($"Do you sure you want to delete this edible food?", "Delete food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var pro = GetFood();
                    foodRepository.DeleteFood(pro);
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
            try
            {
                
                MessageBox.Show("Added successfully", "Add new food", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Added new food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadFood()
        {
            var foodList = foodRepository.GetAllFoods();
            try
            {

                source = new BindingSource();
                source.DataSource = foodList;

                txtFoodID.DataBindings.Clear();
                txtFoodName.DataBindings.Clear();
                txtExpiredDate.DataBindings.Clear();
                
                txtFoodID.DataBindings.Add("Text", source, "Id");
                txtFoodName.DataBindings.Add("Text", source, "Name");
                txtExpiredDate.DataBindings.Add("Text", source, "ImportedDateTime");
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
        private Food GetFood()
        {
            Food food = null;
            try
            {
                food = new Food
                {
                    Id = int.Parse(txtFoodID.Text),
                    Name = txtFoodName.Text,
                    ExpiredDate = DateTime.Parse(txtExpiredDate.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Food");
            }
            return food;
        }
    }
}
