using Animal_Management_System.Models;
using Animal_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal_Management_System.Repository.Implementation;

namespace Animal_Management_System_Form.Food_Form
{
    public partial class FoodDetails : Form
    {
        private IFoodRepository foodRepository;
        private Food updateFood;
        public int updatedFoodId;
        


        public FoodDetails()
        {
            InitializeComponent();
            foodRepository = new ImplFoodRepository();
        }
        

        private void FoodDetails_Load(object sender, EventArgs e)
        {
            updateFood = foodRepository.GetFoodById(updatedFoodId);
            txtFoodId.Text = updateFood.Id.ToString();
            txtFoodName.Text = updateFood.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var foodId = Convert.ToInt32(txtFoodId.Text);
            var foodName = txtFoodName.Text;
            DateTime expireDateTime = dateTimePicker1.Value;
            if (expireDateTime < DateTime.Now)
            {
                MessageBox.Show("Expired Date is lower today!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("Enter Food Name please!!");
                return;
            }
            foodRepository.UpdateFood(new Food{ Id = foodId ,Name = foodName, ExpiredDate = expireDateTime});
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
